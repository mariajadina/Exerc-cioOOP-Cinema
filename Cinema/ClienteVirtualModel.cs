using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class ClienteVirtualModel
    {
        private List<ClienteVirtual> clientesVirtuais = new List<ClienteVirtual>();
        public ClienteVirtualModel()
        {
            clientesVirtuais.Add(new ClienteVirtual("João Cleber", "20/09/1976", "596.365.965-08", "(47) 96542-6354", "joaocleberdarevelacao@yahoo.com", "Sem benefício"));
            clientesVirtuais.Add(new ClienteVirtual("Lêoncio Walrus", "20/09/1865", "694.965.965-29", "(47) 92654-3165", "leonciobolinadegorfe@gmail.com", "Idoso"));
            clientesVirtuais.Add(new ClienteVirtual("Marcos Brás", "20/09/1976", "265.986.564-52", "(47) 93654-356", "marcosflamengo1981@yahoo.com", "Idoso"));
            clientesVirtuais.Add(new ClienteVirtual("Penelope Charmosa", "20/09/2000", "872.365.965-52", "(47) 95642-1212", "penelopevrumo@yahoo.com", "Sem benefício"));            
            clientesVirtuais.Add(new ClienteVirtual("Maduh Silva", "20/09/1976", "596.365.965-09", "(47) 98659-3569", "maduhhhhhhhh@yahoo.com", "Sem benefício"));
            clientesVirtuais.Add(new ClienteVirtual("Karl Marxs", "05/05/1818", "562.562.564-12", "(47) 9654-3541", "killercapitalistsince1818@yahoo.com", "Idoso"));
            clientesVirtuais.Add(new ClienteVirtual("Pedro Souza", "20/09/1976", "384.254.548-86", "(47) 98542-9853", "pedrosouza@yahoo.com", "Sem benefício"));
            clientesVirtuais.Add(new ClienteVirtual("Marge Simpson", "20/09/1976", "753.124.698-69", "(47) 96451-3423", "margesimpson@yahoo.com", "Sem benefício"));
        }

        public void LerLista()
        {
            for (int i = 0; i < clientesVirtuais.Count; i++)
            {
                Console.Write(i + 1);
                clientesVirtuais[i].Listar();
            }
        }
    }
}
