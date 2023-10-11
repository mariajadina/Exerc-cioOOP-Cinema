using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Menu
    {
        public static FilmeModel FilmeModel = new FilmeModel();
        public static SalaModel SalaModel = new SalaModel();
        public static ClienteVirtualModel ClienteVirtualModel = new ClienteVirtualModel();
        public static ClienteFisicoModel ClienteFisicoModel = new ClienteFisicoModel();
        public static PedidoVirtualModel PedidoVirtualModel = new PedidoVirtualModel();

        private static string MenuPrincipal()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1 - Clientes");
            Console.WriteLine("2 - Filmes");
            Console.WriteLine("3 - Salas");
            Console.WriteLine("0 - Sair");
            return Console.ReadLine();
        }
        private static string SubMenuCliente()
        {
            Console.WriteLine("1 - Visualizar lista de clientes");
            Console.WriteLine("2 - Visualizar lista de pedidos");
            Console.WriteLine("3 - Visualizar pedidos por cliente");
            Console.WriteLine("0 - Retornar");
            return Console.ReadLine();
        }
        private static string SubMenuCRUD()
        {
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Visualizar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Retornar");
            return Console.ReadLine();
        }
        public static void MostrarMenuPrincipal()
        {
            Console.Clear();
            switch (MenuPrincipal())
            {
                case "1":
                    MostrarSubMenuCliente();
                    break;
                case "2":
                    MostrarSubMenuFilme();
                    break;
                case "3":
                    MostrarSubMenuSala();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
            }
        }
        public static void MostrarSubMenuCliente()
        {
            Console.Clear();
            switch (SubMenuCliente())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Clientes Virtuais:\n");
                    ClienteVirtualModel.LerLista();
                    Console.WriteLine("Clientes Físicos:\n");
                    ClienteFisicoModel.LerLista();
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    MostrarSubMenuCliente();
                    break;
                case "2":
                    PedidoVirtualModel.LerLista();
                    break;
                case "3":
                    //TODO: função visualizar pedidos por clientes
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    MostrarSubMenuCliente();
                    break;
            }
        }

        public static void MostrarSubMenuFilme(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Filmes");
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (SubMenuCRUD())
            {
                case "1":
                    Console.Clear();
                    FilmeModel.AdicionarItem();
                    MostrarSubMenuFilme("Filme adicionado com sucesso!");
                    break;
                case "2":
                    Console.Clear();
                    FilmeModel.LerLista();
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    MostrarSubMenuFilme();
                    break;
                case "3":
                    Console.Clear();
                    FilmeModel.AtualizarLista();
                    MostrarSubMenuFilme("Filme alterado com sucesso!");
                    break;
                case "4":
                    Console.Clear();
                    FilmeModel.RemoverItem();
                    MostrarSubMenuFilme("Filme removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    MostrarSubMenuFilme();
                    break;
            }
        }

        public static void MostrarSubMenuSala(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Salas");
            Console.WriteLine(mensagem);
            Console.WriteLine();
            switch (SubMenuCRUD())
            {
                case "1":
                    Console.Clear();
                    SalaModel.AdicionarItem();
                    MostrarSubMenuSala("Sala adicionada com sucesso!");
                    break;
                case "2":
                    Console.Clear();
                    SalaModel.LerLista();
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    MostrarSubMenuSala();
                    break;
                case "3":
                    Console.Clear();
                    SalaModel.AtualizarLista();
                    MostrarSubMenuSala("Sala alterada com sucesso!");
                    break;
                case "4":
                    Console.Clear();
                    SalaModel.RemoverItem();
                    MostrarSubMenuSala("Sala removida com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadLine();
                    MostrarSubMenuSala();
                    break;
            }
        }
    }
}
