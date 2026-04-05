using System;

namespace Variaveis
{
    class Run
    {
        public static void run()
        {
            Var.VarBasica();
        }
    }

    class Especificas
    {
        static void Main(string[] args)
        {
            string nome = "Ariel"; //string = texto ""
            int idade = 32; //int = número 
            double metade = 0,5;//double = numero qualquer com .
            decimal dinheiro = 80.50m; // decimal = numeros financeiros com .
            float memory = 1.21421f; //float = dados de jogos e memorias com .
            bool SaldoPositivo = true; //bool = true ou false
            
            Console.WriteLine($"Minha idade é {idade}"); //$ permite usar variaveis dentro da string
            Console.WriteLine(dinheiro);
            Run.run();

        }
    }
    class Var
    {
        public static void VarBasica()
        {
            //também possui o comando var, que não precisa especificar a variavel, ela já mostra o tipo automaticamente de acordo com o que você digita
            var nome2 = "marcio"; //reconhece que é string pelas aspas
            var idade2 = 27; //reconhece que é int por ser só um numéro
            var dinheiro2 = 100.50m; // reconhece que é decimal por ser um número com . e m no final
            var umQuarto = 0,25;//reconhece como double por ser um numero com . e não tendo uma letra no final
            var memory = 23.5643f; //reconhece como float por ser um numero com . e f no final
            var SaldoNegativo2 = false; //reconhe que é bool por ser true ou false
            Console.WriteLine($"Meu nome é {nome2}");
            Console.WriteLine(idade2);
        }
    }
  }