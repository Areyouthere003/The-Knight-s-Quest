using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    internal class Logica
    {
        public static void Logica1() 
        {
            int saludHeroe = 100, ataqueHeroe = 3, defensaHeroe = 2;
            Personajes.Enemigos estas = new Personajes.Enemigos();
            Console.WriteLine("comienza la epica batalla del heroe contra el orco"); //aquí iría la lógica no la historia, la historia estará en otra clase;
            Console.WriteLine("Tus estadisticas");
            estas.Heroe1(saludHeroe, ataqueHeroe, defensaHeroe);
            estas.VidaOrco();
            Console.WriteLine("tu salud es: {0}");
            Console.WriteLine("1) atacar");
            Console.WriteLine("2) defender");
            short opcion = short.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    break;
                case 2:
                    break;
            }
            Console.ReadKey();
        }
        public void estadisticas()
        {
            int ataque;
            int defensa;
            int HP;
        }
    }    
}
