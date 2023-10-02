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
        private double valorTotal { get; set; }
        private string beneficio { get; set; }
        private List<Ingresso> ingressos { get; set; }

        //Construtor
        public Pedido(string nomeCliente, string cpf, double valorTotal, string beneficio, List<Ingresso> ingressos)
        {
            this.nomeCliente = nomeCliente;
            this.cpf = cpf;
            this.valorTotal = valorTotal;
            this.beneficio = beneficio;
            this.ingressos = ingressos;
        }

    }
}
