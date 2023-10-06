using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class FilmeModel
    {
        private List<Filme> filmes = new List<Filme>();

        public FilmeModel()
        {
            filmes.Add(new Filme("Som da Liberdade", "Drama", "14 anos", 135)); 
            filmes.Add(new Filme("Patrulha Canina: um Filme Superpoderoso", "Animação", "Livre", 88));
            filmes.Add(new Filme("Jogos Mortais X", "Terror", "18 anos", 119));
            filmes.Add(new Filme("Os Mercenários 4", "Ação", "18 anos", 103));
        }
        public void AdicionarItem()
        {
            Filme filme = new Filme();
            filme.Popular();
            filmes.Add(filme);
        }

        public void LerLista()
        {
            for (int i = 0; i < filmes.Count; i++)
            {
                Console.Write(i + 1);
                filmes[i].Listar();
            }
        }

        public void AtualizarLista()
        {
            LerLista();
            Console.WriteLine("Digite o id do item que deseja alterar:");
            int id = Convert.ToInt32(Console.ReadLine());
            filmes[id - 1].Popular();
        }

        public void RemoverItem()
        {
            LerLista();
            Console.WriteLine("Digite o id do item que deseja remover:");
            int id = Convert.ToInt32(Console.ReadLine());
            filmes.RemoveAt(id - 1);
        }
    }
}
