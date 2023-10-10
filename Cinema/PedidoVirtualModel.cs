using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class PedidoVirtualModel
    {
        private List<PedidoVirtual> pedidosVirtuais = new List<PedidoVirtual>();

        public PedidoVirtualModel()
        {
            pedidosVirtuais.Add(new PedidoVirtual("João Cleber", "596.365.965-08", "Patrulha Canina: um Filme Superpoderoso", "Candy", "15", "17:00", 27.00));
            pedidosVirtuais.Add(new PedidoVirtual("Lêoncio Walrus", "694.965.965-29", "Patrulha Canina: um Filme Superpoderoso", "Candy", "16", "17:00", 13.50));
            pedidosVirtuais.Add(new PedidoVirtual("Penelope Charmosa", "265.986.564-52", "Patrulha Canina: um Filme Superpoderoso", "Candy", "17", "17:00", 27.00));
            pedidosVirtuais.Add(new PedidoVirtual("Maduh Silva", "872.365.965-52", "Patrulha Canina: um Filme Superpoderoso", "Candy", "18", "17:00", 27.00));
            pedidosVirtuais.Add(new PedidoVirtual("Karl Marxs", "596.365.965-09", "Patrulha Canina: um Filme Superpoderoso", "Candy", "19", "17:00", 13.50));
            pedidosVirtuais.Add(new PedidoVirtual("Pedro Souza", "562.562.564-12", "Patrulha Canina: um Filme Superpoderoso", "Candy", "20", "17:00", 27.00));
            pedidosVirtuais.Add(new PedidoVirtual("Marcos Brás", "384.254.548-86", "Patrulha Canina: um Filme Superpoderoso", "Candy", "21", "17:00", 13.50));
            pedidosVirtuais.Add(new PedidoVirtual("Marge Simpson", "753.124.698-69", "Patrulha Canina: um Filme Superpoderoso", "Candy", "22", "17:00", 27.00));
        }
        public void LerLista()
        {
            for (int i = 0; i < pedidosVirtuais.Count; i++)
            {
                Console.Write(i + 1);
                pedidosVirtuais[i].Listar();
            }
        }
    }
}
