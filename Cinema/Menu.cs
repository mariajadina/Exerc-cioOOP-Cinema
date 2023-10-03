using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Menu
    {
        public static string MenuPrincipal()
        {
            Console.WriteLine("Menu principal");
            Console.WriteLine("1 - Clientes");
            Console.WriteLine("2 - Filmes");
            Console.WriteLine("3 - Salas");
            Console.WriteLine("0 - Sair");
            return Console.ReadLine();
        }
        public static string SubMenuCliente()
        {
            Console.WriteLine("1 - Visualizar lista de clientes");
            Console.WriteLine("2 - Visualizar lista de pedidos");
            Console.WriteLine("3 - Visualizar pedidos por cliente");
            Console.WriteLine("0 - Retornar");
            return Console.ReadLine();
        }
        public static string SubMenuCRUD()
        {
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Visualizar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Retornar");
            return Console.ReadLine();
        }
    }
}
