﻿using System;
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
            Console.Write("Digite o nome da sala: ");
            nome = Console.ReadLine();

            Console.Write("Digite a quantidade de cadeiras da sala: ");
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

