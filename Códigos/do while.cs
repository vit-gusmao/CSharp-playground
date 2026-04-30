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

        do
            {
                Console.Write("\nDigite a senha que voc� criou: ");
                senhaVerify = Console.ReadLine();

                if (senhaVerify != senha)
                {
                    Console.Write("\nSenha incorreta, tente novamente.");
                }

            } while (senhaVerify != senha); 

            Console.Write("\nSenha correta.");
        }
    }
}