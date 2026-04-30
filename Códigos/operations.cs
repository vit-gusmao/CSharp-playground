using System;
using System.Security.AccessControl;

namespace numbers
{
    class Operations
    {
        static void Main(string[] args)
        {
            //puxar vars da class Dados (sempre colocar em cima do código)
            Dados dados = new Dados();


            //double: matemática + - * / %
            Console.WriteLine("Quantos quadrados inteiros de chocolate você tem?");
            double chocolates = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Se você quebrar todos ao meio, terá {chocolates * 2} pedaços"); // * multiplicação
            Console.WriteLine($"Se comer metade de um quadrado, ficará com {chocolates - 0.5}"); // - subtração
            Console.WriteLine($"Se dividir tudo igualmente entre 3 pessoas, cada um recebe {chocolates / 3} quadrados"); // / divisão
            Console.WriteLine($"Sobrariam {chocolates % 3} quadrados após dividir entre 3 pessoas"); // % resto da divisão
            Console.WriteLine($"Se juntar mais meio quadrado, você terá {chocolates + 0.5}"); // + adição

            //float (f): jogo, memory
            Console.WriteLine("Digite sua velocidade no jogo (ex: 10.5)");
            float velocidade = Convert.ToSingle(Console.ReadLine()); // Convertendo para float
            Console.WriteLine($"Se pegar um boost 2x, sua velocidade será {velocidade * 2}"); 
            Console.WriteLine($"Se tomar um debuff de 1.5, ficará com {velocidade - 1.5f}"); 
            Console.WriteLine($"Se dividir sua velocidade entre 2 jogadores, cada um terá {velocidade / 2}"); 
            Console.WriteLine($"O resto da divisão da velocidade por 3 é {velocidade % 3}"); 
            Console.WriteLine($"Se ganhar +5 de velocidade, ficará com {velocidade + 5f}"); 


            //c# tem uma sintese de se colocar ++ na var, é como se fosse mais 1, porém o dado fica armazenado na var como um incremento.
            //c# possui diferentes tipos de classificar var com numeros decimais, possui: double, decimal e float
            //++var
            Console.WriteLine("Qual sua idade ?");
            int idadeAniversario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"no seu proximo aniversário você terá {++idadeAniversario} anos");
            Console.WriteLine($"ficou armazenado o valor {idadeAniversario}");
           
            //var++ com decimal (m): dinheiro, financias 
            Console.WriteLine("Digite o seu Nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu saldo");
            decimal saldo = Convert.ToDecimal(Console.ReadLine());// convertendo Console.ReadLine para Decimal
            Console.WriteLine($"Seu nome é {nome} e seu saldo é {saldo:C}");// var:C é para formatar o numero para o valor do dinheiro da região do sistema
            Console.WriteLine($"você ganhou {dados.dinheiro:C} reais e agora tem {saldo + dados.dinheiro++:C} reais!");
            Console.WriteLine($"que pena, você perdeu tudo, agora você tem {saldo - saldo}");
            

        }

        class Dados

        { 
            public decimal dinheiro = 100000.00m;//deve haver um m no final do decimal

        }


    }
}
