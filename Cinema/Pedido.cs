using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Pedido
    {
        //Atributos
        private string nomeCliente { get; set; }
        private string cpf { get; set; }
        private string tituloFilme { get; set; }
        private string nomeSala { get; set; }
        private string cadeira { get; set; }
        private string horario { get; set; }
        private double valorTotal { get; set; }
        private string tipoPagemnto { get; set; }

        public Pedido(string nomeCliente = null, string cpf = null, string tituloFilme = null, string nomeSala = null, string cadeira = null, string horario = null, double valorTotal = 0, string tipoPagemnto = null)
        {
            if (!string.IsNullOrEmpty(nomeCliente))
            {
                this.nomeCliente = nomeCliente;
            }
            if (!string.IsNullOrEmpty(cpf))
            {
                this.cpf = cpf;
            }
            if (!string.IsNullOrEmpty(tituloFilme))
            {
                this.tituloFilme = tituloFilme;
            }
            if (!string.IsNullOrEmpty(nomeSala))
            {
                this.nomeSala = nomeSala;
            }
            if (!string.IsNullOrEmpty(cadeira))
            {
                this.cadeira = cadeira;
            }
            if (!string.IsNullOrEmpty(horario))
            {
                this.horario = horario;
            }
            if (valorTotal > 0)
            {
                this.valorTotal = valorTotal;
            }
        }
    }
}
