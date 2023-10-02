using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Pagamento
    {
        //Atributos
        private string tipoPag;

        public string TipoPag
        {
            get
            {
                return tipoPag;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    TipoPag = value;
                } else
                {
                    throw new Exception("Valor inválido para pagamento.");
                }
            }
        }
    }
}
