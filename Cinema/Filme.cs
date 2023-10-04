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

        public void Popular()
        {
            Console.Write("Digite o nome do filme: ");
            titulo = Console.ReadLine();

            Console.Write("Digite o genêro do filme: ");
            genero = Console.ReadLine();

            Console.Write("Digite a classe indicativa do filme: ");
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