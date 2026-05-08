$ErrorActionPreference = "Stop"

$repoRoot = Resolve-Path (Join-Path $PSScriptRoot "..")
$project = Get-ChildItem -Path $repoRoot -Recurse -Filter "Operators.csproj" | Select-Object -First 1

if (-not $project) {
  throw "Não encontrei Operators.csproj abaixo de $repoRoot"
}

$projectDir = Split-Path -Parent $project.FullName

function Stop-OperatorsLocks {
  # Se uma execução antiga estiver rodando, ela bloqueia o build (MSB3027/MSB3021).
  # Em .NET moderno, quem segura o lock pode ser o próprio app (Operators.exe) OU o host (dotnet/.NET Host).
  Get-Process -Name "Operators" -ErrorAction SilentlyContinue | Stop-Process -Force -ErrorAction SilentlyContinue

  # Mata hosts dotnet/.NET Host que estejam rodando esse projeto/pasta.
  try {
    $dotnetLike = Get-CimInstance Win32_Process |
      Where-Object {
        ($_.Name -in @("dotnet.exe", "dotnet", ".NET Host", ".NET Host.exe")) -and
        ($_.CommandLine) -and
        (
          # Alguns hosts não carregam o caminho completo do projeto no CommandLine.
          ($_.CommandLine -match [regex]::Escape($projectDir)) -or
          ($_.CommandLine -match "Operators(\.dll|\.exe)?") -or
          ($_.CommandLine -match "CSharp-Playground")
        )
      }

    foreach ($p in $dotnetLike) {
      Stop-Process -Id $p.ProcessId -Force -ErrorAction SilentlyContinue
    }
  } catch {
    # Se o CIM falhar por permissão/ambiente, seguimos.
  }
}

Stop-OperatorsLocks

try {
  # Importante: ao parar (Ctrl+C) o PowerShell sai e cai no finally,
  # que encerra qualquer host que tenha ficado prendendo DLL/EXE.
  dotnet run --project $project.FullName
} finally {
  Stop-OperatorsLocks
}

