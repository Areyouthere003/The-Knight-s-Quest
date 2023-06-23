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
            int saludHeroe, ataqueHeroe = 5, estadisticaEnemigo;
            int SaludOrco = 200, ataqueOrco = 1, defensaOrco = 2;
            int saludLich = 250, ataqueLich = 3, defensaLich = 2;
            int saludDarkKnight = 280, ataqueDK = 5 , defensaDK = 4;
            int saludWizard = 300, ataqueWizard = 4, defensaWizard = 0;
            int saludDarkDemonKing = 400, ataqueDDK = 6, defensaDDK = 6; 
            Historia historia = new Historia();
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(SaludOrco, ataqueOrco, defensaOrco);
            historia.Introduccion();
            historia.PrimerJefe();
            saludHeroe = variable1.RetornoHeroe();
            estadisticaEnemigo = variable2.RetornoOrco();
            while (variable1.RetornoHeroe() > 1 || variable2.RetornoOrco() > 1)
            {
                Console.WriteLine("");
                Console.WriteLine("tu salud es: {0}", saludHeroe);
                Console.WriteLine("La salud del enemigo es: {0}", estadisticaEnemigo);
                Console.WriteLine("");
                Console.WriteLine("1) atacar");
                Console.WriteLine("2) defender");
                short opcion = short.Parse(Console.ReadLine());
                switch (opcion)
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
        }
        public void estadisticas()
        {
            int ataque;
            int defensa;
            int HP;
        }
    }    
}
