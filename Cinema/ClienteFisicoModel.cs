using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class ClienteFisicoModel
    {
        private List<ClienteFisico> clientesFisicos = new List<ClienteFisico>();
        public ClienteFisicoModel()
        {
            clientesFisicos.Add(new ClienteFisico("PCD"));
            clientesFisicos.Add(new ClienteFisico("Assinante do NSC Total"));
            clientesFisicos.Add(new ClienteFisico("Idoso"));
            clientesFisicos.Add(new ClienteFisico("PCD"));
            clientesFisicos.Add(new ClienteFisico("Estudante"));
            clientesFisicos.Add(new ClienteFisico("Estudante"));
            clientesFisicos.Add(new ClienteFisico("Idoso"));
            clientesFisicos.Add(new ClienteFisico("Idoso"));
        }

        public void LerLista()
        {
            for (int i = 0; i < clientesFisicos.Count; i++)
            {
                Console.Write(i + 1);
                clientesFisicos[i].Listar();
            }
        }
    }
}
