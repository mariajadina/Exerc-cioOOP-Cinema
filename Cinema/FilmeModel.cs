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

        public void CriarLista()
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
            filmes[id].Popular();
        }

        public void RemoverItem()
        {
            LerLista();
            Console.WriteLine("Digite o id do item que deseja remover:");
            int id = Convert.ToInt32(Console.ReadLine());
            filmes.RemoveAt(id);
        }
    }
}
