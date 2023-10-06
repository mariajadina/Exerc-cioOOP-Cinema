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
        private List<string> horarios { get; set; } = new List<string>();

        public Filme(string titulo = "", string genero = "", string classIndicativa = "", int duracao = 0, List<string> horarios = null)
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
            if (horarios != null)
            {
                this.horarios = horarios;
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

            HorarioFilme();
        }

        public void Listar()
        {
            Console.WriteLine($" Nome: {titulo}");
            Console.WriteLine($" Genêro: {genero}");
            Console.WriteLine($" Classificação Indicativa: {classIndicativa}");
            Console.WriteLine($" Duração: {duracao} min.");
            Console.WriteLine($" Horários: {string.Join(" - ", horarios)}");
            Console.WriteLine("-----------------------");

        }
        public void HorarioFilme()
        {
            Console.Write("Digite a quantidade de sessões que gostaria de adicionar para esse filme: ");
            int sessao = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sessao; i++)
            {
                Console.Write($"Digite o horário da sessão {i + 1}: ");
                string horario = Console.ReadLine();
                horarios.Add(horario);
            }

        }
    }

}