using System;
using System.Collections.Generic;
namespace AulaPOO_ProjetoProdutoSENAI.Classes
{
    public class Login
    {
        public bool Logar { get; set; } = true;
<<<<<<< HEAD
=======
        public bool Voltar { get; set; } = true;
        Marca novaMarca = new Marca();
        Produto novoProduto = new Produto();

        Usuariocs cadastrar = new Usuariocs();
        int codigo = 0;

>>>>>>> 1fc2713b7638281552c983a865f6a71b18c881de

        public Login()

        {

<<<<<<< HEAD
            Console.WriteLine("Bem vindo ao sistema do nosso projeto!\nPara ter o acesso do menu você deve fazer um cadastro.\nVocê deseja acessar o sistema? (S/N)");
            string acessoSistema = Console.ReadLine().ToUpper();
=======
            Console.WriteLine("Bem vindo ao sistema do nosso projeto!\nPara ter o resposta do menu você deve fazer um cadastro.\nVocê deseja acessar o sistema? (S/N)");
            string respostaSistema = Console.ReadLine().ToUpper();
>>>>>>> 1fc2713b7638281552c983a865f6a71b18c881de

            do
            {
                do
                {
<<<<<<< HEAD
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
=======
                    switch (respostaSistema)
                    {
                        case "S":
                            Console.WriteLine("Vamos ao Cadastro!");
                            Console.WriteLine("Digite seu nome completo: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Digite seu e-mail: ");
                            string email = Console.ReadLine();
                            Console.WriteLine("Digite seu e-mail novamente: ");
                            string emailNovamente = Console.ReadLine();
                            Console.WriteLine("Digite a sua senha: ");
                            string senha = Console.ReadLine();
                            Console.WriteLine("Digite a sua senha novamente: ");
                            string senhaNovamente = Console.ReadLine();
                            codigo = +1;

                            Usuariocs novoUsuario = new Usuariocs(codigo, nome, email, senha);
                            Console.WriteLine(cadastrar.Cadastrar(novoUsuario));
                            break;
                        case "N":
                            Console.WriteLine("Até logo!");
                            Logar = false;
                            Voltar = false;
                            break;
                        default:
                            Console.WriteLine("Digite uma opção válida.");
                            break;
                    }

                } while (Voltar);

            } while (Logar);
        }
    }
}

>>>>>>> 1fc2713b7638281552c983a865f6a71b18c881de
