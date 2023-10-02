using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Ingresso
    {
        //Matar
        //Atributos
        private string tituloFilme;
        private string nomeSala;
        private string cadeira;
        private double preco;
        private string horario;

        //Construtor
        public Ingresso(string tituloFilme, string nomeSala, string cadeira, double preco, string horario)
        {
            this.tituloFilme = tituloFilme;
            this.nomeSala = nomeSala;
            this.cadeira = cadeira;
            this.preco = preco;
            this.horario = horario;
        }
    }
}
