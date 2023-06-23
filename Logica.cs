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
            int saludHeroe = 50, ataqueHeroe = 5, saludEnemigo = 1;
            int SaludOrco = 200, ataqueOrco = 1, defensaOrco = 2;
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(SaludOrco, ataqueOrco, defensaOrco);
            Console.WriteLine("comienza la epica batalla del heroe contra el orco"); //aquí iría la lógica no la historia, la historia estará en otra clase;
            Console.WriteLine("Tus estadisticas");
            saludHeroe = variable1.RetornoHeroe();
            Console.WriteLine("tu salud es: {0}", saludHeroe);
            int a = variable2.RetornoOrco();
            Console.WriteLine("La salud del enemigo es: {0}", a);
            Console.WriteLine("1) atacar");
            Console.WriteLine("2) defender");
            short opcion = short.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    variable1.Heroe(ataqueHeroe);
                    saludHeroe = variable1.RetornoHeroe();
                    Console.WriteLine("tu salud es: {0}", saludHeroe);
                    variable2.Orco(ataqueHeroe);
                    int s = variable2.RetornoOrco();
                    Console.WriteLine("tu salud es: {0}", s);
                    Console.ReadKey();
                    variable1.Heroe(ataqueHeroe);
                    saludHeroe = variable1.RetornoHeroe();
                    Console.WriteLine("tu salud es: {0}", saludHeroe);
                    variable2.Orco(ataqueHeroe);
                    int sas = variable2.RetornoOrco();
                    Console.WriteLine("tu salud es: {0}", sas);
                    Console.ReadKey();


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
