using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Filme
    {
        //Atributos
        private string titulo { get; set; }
        private string genero { get; set; }
        private string classIndicativa { get; set; }
        private int duracao { get; set; }

        public Filme(string titulo = "", string genero = "", string classIndicativa = "", int duracao = 0)
        {
            if (!string.IsNullOrEmpty(titulo))
            {
                this.titulo = titulo;
            }
            if (!string.IsNullOrEmpty(genero))
            {
                this.genero = genero;
            }
            if (!string.IsNullOrEmpty(classIndicativa))
            {
                this.classIndicativa = classIndicativa;
            }
            if (duracao > 0)
            {
                this.duracao = duracao;
            }
        }

        public void Popular()
        {
            Console.Write("Digite o nome do filme: ");
            titulo = Console.ReadLine();

            Console.Write("Digite o genêro do filme: ");
            genero = Console.ReadLine();

            Console.Write("Digite a classificação indicativa do filme: ");
            classIndicativa = Console.ReadLine();

            Console.Write("Digite a duração em minutos do filme: ");
            duracao = Convert.ToInt32(Console.ReadLine());
        }

        public void Listar()
        {
            Console.WriteLine($" Nome: {titulo}");
            Console.WriteLine($" Genêro: {genero}");
            Console.WriteLine($" Classificação Indicativa: {classIndicativa}");
            Console.WriteLine($" Duração: {duracao}");
            Console.WriteLine("-----------------------");

        }
    }

}