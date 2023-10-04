using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Menu
    {
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
                    MostrarSubMenuCRUD();
                    break;
                case "3":
                    MostrarSubMenuCRUD();
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
                    //TODO: função visualizar lista de cliente
                    break;
                case "2":
                    //TODO: função visualizar lista de pedidos
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
        public static void MostrarSubMenuCRUD()
        {
            Console.Clear();
            switch (SubMenuCRUD())
            {
                case "1":
                    //TODO: Create
                    break;
                case "2":
                    //TODO: Read
                    break;
                case "3":
                    //TODO: Update
                    break;
                case "4":
                    //TODO: Delete
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
    }
}
