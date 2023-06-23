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
            bool valid; int opcion, condatq;
            int saludHeroe, ataqueHeroe = -5, estadisticaEnemigo;
            int SaludOrco = 200, ataqueOrco = 1, defensaOrco = 2;
            int saludLich = 250, ataqueLich = 3, defensaLich = 2;
            int saludDarkKnight = 280, ataqueDK = 5 , defensaDK = 4;
            int saludWizard = 300, ataqueWizard = 4, defensaWizard = 0;
            int saludDarkDemonKing = 400, ataqueDDK = 6, defensaDDK = 6;
            Ataques ataques = new Ataques();
            Historia historia = new Historia();
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(SaludOrco, ataqueOrco, defensaOrco);
            //historia.Introduccion();
            //historia.PrimerJefe();
            saludHeroe = variable1.RetornoHeroe();
            estadisticaEnemigo = variable2.RetornoOrco();
            while (variable1.RetornoHeroe() > 1 || variable2.RetornoOrco() > 1)
            {
                Console.WriteLine("");
                Console.WriteLine("tu salud es: {0}", saludHeroe);
                Console.WriteLine("La salud del enemigo es: {0}", estadisticaEnemigo);
                Console.WriteLine("");
                historia.Baraja();
                do
                {
                    Console.WriteLine("Escoja la carta (número)");
                    valid = int.TryParse(Console.ReadLine(), out opcion);
                    if(opcion >0 && opcion <13)
                    {
                        valid= true;
                    }
                    else
                    {
                        valid = false;
                        Console.WriteLine("numero incorrecto, eliga un número de la lista");
                        Console.WriteLine("");
                    }
                }
                while (!valid);
                switch (opcion)
                {
                    case 1:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Puño());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 2:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Espadazo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 3:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Cargazo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 4:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Pasivo());
                        variable1.Heroe(ataques.Pocion());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break; 
                    case 5:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        variable1.Heroe(ataques.BendicionSagrada());
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Dolor());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 6:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.MaestroEspadas());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 7:
                        variable1.Heroe(ataques.DefensaAbsoluta(ataques.AtqEnemigo()));
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Cargazo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 8:
                        variable1.Heroe(ataques.AtqEnemigo());            
                        saludHeroe = variable1.RetornoHeroe();            
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Veneno());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 9:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe(); 
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Daga());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 10:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.Furia());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    case 11:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.GolpeBajo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
                        break;
                    default:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        variable2.Orco(ataques.HambrienTITO());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es es: {0}", condatq);
                        Console.ReadKey();
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
        /*public void AtaqueSagDolor()
            {
                Personajes heroe = new Personajes();
                Enemigo enemigo = new Enemigo();
                int dolor = Dolor();
                int bendicion = BendicionSagrada();
                heroe.Heroe(bendicion);
            }*/
    }    
}
