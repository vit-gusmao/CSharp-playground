using System;

namespace dowhile
{
    class whiledo
    {
        static void Main(string[] args)
        {
            Console.Write("Crie uma senha: ");
            string senha = Console.ReadLine();

            string senhaVerify;

            do //do começa a ação
            {
                Console.Write("\nDigite a senha que você criou: ");
                senhaVerify = Console.ReadLine();

                if (senhaVerify != senha)
                {
                    Console.Write("\nSenha incorreta, tente novamente.");
                }

            } while (senhaVerify != senha); //while vai repetir até senhaVerify == senha

            Console.Write("\nSenha correta.");

            Console.Write("\nDigite qualquer coisa: ");
            string palavra = Console.ReadLine();

            Console.Write("\n selecione a quantidade de vezes que você quer que a palavra que você digitou apareça: ");
            bool quantidade = Convert.ToBoolean(Console.ReadLine());
            
            int i = 0;

            while (i = quantidade)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}