using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public interface ICRUD
    {
        public void AdicionarItem();
        public void LerLista();
        public void AtualizarLista();
        public void RemoverItem();
    }
}
