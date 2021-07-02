using System;
using Projeto_marcas.Classes;

namespace Projeto_marcas
{
    class Program
    {
        static void Main(string[] args)
        {
            string desejo, opcao;
            Produto p = new Produto();
            Marca m = new Marca();
            Login l = new Login();
            Usuario u = new Usuario();

            Console.WriteLine("Você quer logar? (S/N)");
            desejo = Console.ReadLine().ToLower();
            while (l.Logado == false)
            {
                if (desejo == "s")
                {
                    l.Logar();
                }
                else if (desejo == "n")
                {
                    l.Logado = true;
                    Console.WriteLine("Quer ir embora mesmo? Digite 0");
                }

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Write("Qual o nome do usuario? ");
                        string nomeUsuario = Console.ReadLine();
                        Console.Write("Qual o email do usuario? ");
                        string emailUsuario = Console.ReadLine();
                        Console.Write("Qual a senha do usuario? ");
                        string senhaUsuario = Console.ReadLine();

                        u.listaDeUsuario.Add(new Usuario(nomeUsuario, emailUsuario, senhaUsuario));
                        break;

                    case "2":
                        Console.Write("Qual o nome da marca? ");
                        string NomeMarca = Console.ReadLine();

                        m.listaDeMarcas.Add(new Marca(NomeMarca));
                        break;

                    case "3":
                        Console.Write("Qual o nome do produto cadastrado? ");
                        string NomeProduto = Console.ReadLine();

                        Console.Write("Qual o preço do produto cadastrado? ");
                        float PrecoProduto = float.Parse(Console.ReadLine());

                        p.listaDeProdutos.Add(new Produto(NomeProduto, PrecoProduto));
                        break;

                    case "4":
                        foreach (Marca item in m.listaDeMarcas)
                        {
                            Console.WriteLine($"{item.codigo} - {item.nomeMarca} - {item.dataCadastro}");
                        }
                        break;

                    case "5":
                        foreach (Produto item in p.listaDeProdutos)
                        {
                            Console.WriteLine($"{item.codigo} - {item.nomeProduto} - R${item.precoProduto} - {item.dataCadastro}");
                        }
                        break;

                    case "6":
                        foreach (Usuario item in u.listaDeUsuario)
                        {
                            Console.WriteLine($"{item.codigo} - {item.nomeUsuario} - {item.emailUsuario} - {item.dataCadastro}");
                        }
                        break;

                    case "7":
                        Console.Write("Qual o código da marca que você quer remover? ");
                        int marcaRemover = int.Parse(Console.ReadLine());
                        m.listaDeMarcas.RemoveAll(x => x.codigo == marcaRemover);
                        break;

                    case "8":
                        Console.Write("Qual o código do produto que você quer remover? ");
                        int produtoRemover = int.Parse(Console.ReadLine());
                        p.listaDeProdutos.RemoveAll(x => x.codigo == produtoRemover);
                        break;

                    case "9":
                        Console.Write("Qual o código do usuario que você quer remover? ");
                        int usuarioRemover = int.Parse(Console.ReadLine());
                        u.listaDeUsuario.RemoveAll(x => x.codigo == usuarioRemover);
                        break;

                    case "0":
                        l.Deslogar();
                        break;
                }
            }
        }
    }
}
