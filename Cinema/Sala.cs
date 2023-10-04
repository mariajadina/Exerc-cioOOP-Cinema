using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Sala
    {
        //Atributos
        private string nome { get; set; }
        private int qtdCadeiras { get; set; }

        public void Popular()
        {
            Console.Write("Digite o nome do filme: ");
            nome = Console.ReadLine();

            Console.Write("Digite a duração em minutos do filme: ");
            qtdCadeiras = Convert.ToInt32(Console.ReadLine());
        }

        public void Listar()
        {
            Console.WriteLine($" Nome: {nome}");
            Console.WriteLine($" Quantidade de Cadeiras: {qtdCadeiras}");
            Console.WriteLine("--------------------------");

        }
    }
}

