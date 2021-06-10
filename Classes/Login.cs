using System;
using System.Collections.Generic;
namespace AulaPOO_ProjetoProdutoSENAI.Classes
{
    public class Login
    {
        public bool Logar { get; set; } = true;

        public Login()

        {

            Console.WriteLine("Bem vindo ao sistema do nosso projeto!\nPara ter o acesso do menu você deve fazer um cadastro.\nVocê deseja acessar o sistema? (S/N)");
            string acessoSistema = Console.ReadLine().ToUpper();

            do
            {
                do
                {
                    if (acessoSistema == "S")
                    {
                        Console.WriteLine("Vamos ao Cadastro!");
                        Console.WriteLine("Digite seu e-mail: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite seu e-mail novamente: ");
                        string emailNovamente = Console.ReadLine();
                        Console.WriteLine("Digite a sua senha: ");
                        string senha = Console.ReadLine();
                        Console.WriteLine("Digite a sua senha novamente: ");
                        string senhaNovamente = Console.ReadLine();
                    }

                    else if (acessoSistema == "N")
                    {
                        Console.WriteLine("Até logo!");
                        Logar = false;
                    }

                    else
                    {
                        Console.WriteLine("Digite uma opção válida.");
                    }

                } while (acessoSistema != "S" && acessoSistema != "N");
            } while (Logar);

        }

    }

}