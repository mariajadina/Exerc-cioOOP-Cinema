using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Login
    {
        public static void LoginUsuario()
        {

            for (int i = 3; i > 0; i--)
            {
                Console.Write("Digite o usuário: ");
                string usuario = Console.ReadLine();

                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();

                if (usuario == "joaocleber" && senha == "1234")
                {
                    Console.Clear();
                    Menu.MostrarMenuPrincipal();
                    return;
                }
                else if (i != 1)
                {
                    Console.Clear();
                    Console.WriteLine($"Usuário ou senha Inválida! Você tem mais {i - 1} tentativa(s)");
                    Console.WriteLine("-------------------------------------------------------");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tentativas inválidas. Tente em outro momento!");     
                }
            }
        }
    }
}
