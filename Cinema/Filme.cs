using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Filme
    {
        //Atributos
        private string titulo { get; set; }
        private string genero { get; set; }
        private string classIndicativa { get; set; }
        private int duracao { get; set; }

        //Construtor
        public Filme(string titulo, string genero, string classIndicativa, int duracao)
        {
            this.titulo = titulo;            
            this.genero = genero;
            this.classIndicativa = classIndicativa;
            this.duracao = duracao;
        }
        public void Mostrar()
        {
            Console.WriteLine(this.titulo);
            Console.WriteLine(this.genero);
            Console.WriteLine(this.classIndicativa);
            Console.WriteLine(this.duracao);
        }
    }
}
