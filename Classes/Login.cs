using System;
using System.Collections.Generic;
namespace AulaPOO_ProjetoProdutoSENAI.Classes
{
    public class Login
    {
        public bool Logado { get; set; } = true;

        int _codigo = 0;

        int opcao;
        bool checarUsuario = true;

        Usuariocs novoUsuario = new Usuariocs();
        Marca marcaNova = new Marca();

        Produto produtoNovo = new Produto();

        Usuariocs encontrarUsuario;

        string nomeM;
        string nomeP;

        public Login()

        {

            Console.WriteLine("Bem vindo ao sistema do nosso projeto!\nPara ter o acesso do menu você deve fazer um cadastro.\nVocê deseja fazer um cadastro? (S/N)");
            string acessoSistema = Console.ReadLine().ToUpper();

            if (acessoSistema == "S")
            {
                Console.WriteLine("Digite seu nome: ");
                string _nome = Console.ReadLine().ToLower();
                _codigo = +1;
                Console.WriteLine("Digite seu email: ");
                string _email = Console.ReadLine().ToLower();
                Console.WriteLine("Digite sua senha: ");
                string _senha = Console.ReadLine();
                Usuariocs cs1 = new Usuariocs(_codigo, _nome, _email, _senha);
                Console.WriteLine(novoUsuario.Cadastrar(cs1));

                Console.WriteLine("Deseja Fazer Login? (S/N)");
                string _fazerlogin = Console.ReadLine().ToUpper();

                if (_fazerlogin == "S")
                {
                    do
                    {
                        Console.WriteLine("Digite seu email: ");
                        string confirmaremail = Console.ReadLine().ToLower();
                        Console.WriteLine("Digite sua senha: ");
                        string confirmarsenha = Console.ReadLine();

                        encontrarUsuario = novoUsuario.ListaUsuario.Find(x => x.Email == confirmaremail && x.Senha == confirmarsenha);

                        if (encontrarUsuario != null)
                        {
                            Console.WriteLine(Logar(novoUsuario));
                            checarUsuario = false;
                        }
                        else
                        {
                            Console.WriteLine("O email ou a senha estão incorretos");
                        }
                    } while (checarUsuario == true);
                    checarUsuario = true;

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(@"
_________________________________________________
|                     MENU                      |
|_______________________________________________|
| 1- Cadastrar marca      4 - Cadastrar Produto |
|                                               |
| 2 - Listar marcas       5 - Listar Produtos   |
|                                               |
| 3- Deletar marca        6 - Deletar produto   |
|                                               |
|                7 - Sair                       |
|_______________________________________________|
");
                        Console.ResetColor();
                        opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Insira o nome da marca: ");
                                nomeM = Console.ReadLine();
                                Console.Write("Digite o código da marca: ");
                                int codigoM = int.Parse(Console.ReadLine());
                                Marca m = new Marca(codigoM, nomeM);
                                Console.WriteLine(marcaNova.Cadastrar(m));
                                break;

                            case 2:
                                if (marcaNova.ListaMarca.Count == 0)
                                {
                                    Console.WriteLine("Sua lista está vazia");
                                }
                                else
                                {
                                    foreach (var item in marcaNova.Listar())
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine($@"
|--------------------------------------|
|           Marcas Cadastradas         |                           
|--------------------------------------|
|Nome da marca: {item.NomeMarca}       
|Código da marca: {item.Codigo}                                   
|--------------------------------------|

                                    ");
                                        Console.ResetColor();
                                    }

                                }
                                break;

                            case 3:
                                Console.Write("Digite o nome da marca que você deseja deletar: ");
                                string deletarM = Console.ReadLine();
                                if (deletarM != nomeM)
                                {
                                    Console.WriteLine("Essa marca não existe");
                                }
                                else
                                {
                                    Marca deletarMarca = marcaNova.ListaMarca.Find(x => x.NomeMarca == deletarM);
                                    Console.WriteLine(marcaNova.Deletar(deletarMarca));
                                }

                                break;

                            case 4:
                                if (marcaNova.ListaMarca.Count == 0)
                                {
                                    Console.WriteLine("Antes de cadastrar um produto, cadastre uma marca.");
                                }
                                else
                                {

                                    bool marcaOk = false;

                                    do
                                    {
                                        Console.Write("Digite o nome do produto: ");
                                        nomeP = Console.ReadLine();
                                        Console.Write("Digite o preço do produto: ");
                                        float precoP = float.Parse(Console.ReadLine());
                                        Console.Write("Digite o código do produto: ");
                                        int codigoP = int.Parse(Console.ReadLine());
                                        Console.Write("Digite a marca do produto: ");
                                        string marcaP = Console.ReadLine();
                                        if (marcaP != nomeM)
                                        {
                                            Console.WriteLine("Essa marca não está cadastrada.\nCadastre-a antes de cadastrar o produto.");
                                            marcaOk = false;
                                        }
                                        else
                                        {
                                            Marca casdastrarProduto = marcaNova.ListaMarca.Find(x => x.NomeMarca == marcaP);
                                            Usuariocs usuarioProduto = encontrarUsuario;
                                            Console.WriteLine($"Produto cadastrado por: {_nome}");
                                            Produto produtoCadastrado = new Produto(codigoP, nomeP, precoP, casdastrarProduto, usuarioProduto);
                                            Console.WriteLine(produtoNovo.Cadastrar(produtoCadastrado));
                                        }


                                    } while (marcaOk);



                                }
                                break;
                            case 5:
                                if (produtoNovo.ListaProduto.Count == 0)
                                {
                                    Console.WriteLine("Sua lista está vazia.");
                                }
                                else
                                {
                                    foreach (var item in produtoNovo.Listar())
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                        Console.WriteLine($@"
|--------------------------------------|
|          Produtos Cadastrados        |                           
|--------------------------------------|
|Nome do produto: {item.NomeProduto}   
|Marca do produto: {item.marca.NomeMarca}
|Código do produto: {item.CodigoP}     
|Preço do produto: {item.Preco:C2}     
|Cadastrado por: {_nome}                                       
|--------------------------------------|

                                    ");
                                        Console.ResetColor();
                                    }
                                }
                                break;
                            case 6:
                                Console.Write("Digite o nome do produto que você deseja deletar: ");
                                string deletarP = Console.ReadLine();
                                if (deletarP != nomeP)
                                {
                                    Console.WriteLine("Esse produto não existe");
                                }
                                else
                                {
                                    Produto deletarProduto = produtoNovo.ListaProduto.Find(x => x.NomeProduto == deletarP);
                                    Console.WriteLine(produtoNovo.Deletar(deletarProduto));
                                }

                                break;
                            case 7:
                                Console.WriteLine(Deslogar(novoUsuario));
                                break;

                            default:
                                break;
                        }
                    } while (opcao != 7);
                }
                else
                {
                    Console.WriteLine("Tchau");
                }
            }

            else
            {
                Console.WriteLine("Tchau");
            }
        }
        public string Logar(Usuariocs usuario)
        {
            return "Você está logado!";
        }
        public string Deslogar(Usuariocs usuario)
        {
            return ("Você está deslogado!");
        }
    }
}
