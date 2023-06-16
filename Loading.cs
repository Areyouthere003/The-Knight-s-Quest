using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class Loading
    {
        public static void Carga()
        {
            int vel = 100;
            string texto = "█░░ █▀█ ▄▀█ █▀▄ █ █▄░█ █▀▀\r\n";
            string texto2 = "█▄▄ █▄█ █▀█ █▄▀ █ █░▀█ █▄█ ▄ ▄ ▄";
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("                       ");
            for (int i = 0; i < texto.Length; i++) 
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Console.Write("                       ");
            for (int i = 0; i < texto2.Length; i++)
            {
                Console.Write(texto2[i]);
                Thread.Sleep(vel);
            }
        }
    }
}
