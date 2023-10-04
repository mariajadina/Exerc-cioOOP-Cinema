using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Pedido
    {
        //Atributos
        private string nomeCliente {  get; set; }
        private string cpf { get; set; }
        private string tituloFilme { get; set; }
        private string nomeSala { get; set; }
        private string cadeira { get; set; }
        private string horario { get; set; } 
        private double valorTotal { get; set; }
        private string beneficio { get; set; }
        private string tipoPagemnto { get; set; }
        
    }
}
