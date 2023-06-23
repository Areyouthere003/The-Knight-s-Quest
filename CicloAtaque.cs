using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class CicloAtaque
    {
        private int estadisticaEnemigo;
        private int estadisticaP;
        bool valid; int opcion, condatq;
        public void cicloAtaque(int saludHeroe, int SaludOrco)
        {
            Ataques ataques = new Ataques();
            Historia historia = new Historia();
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(SaludOrco);
            int heroe = variable1.RetornoHeroe(), malo = variable2.RetornoOrco();
            estadisticaEnemigo = SaludOrco;
            estadisticaP = saludHeroe;
            do
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
                    if (opcion > 0 && opcion < 13)
                    {
                        if (historia.Ver1() == opcion || historia.Ver2() == opcion || historia.Ver3() == opcion)
                        {
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine("no está esa carta");
                            valid = false;
                        }
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
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Puño());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 2:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Espadazo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 3:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Cargazo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 4:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Pasivo());
                        variable1.Heroe(ataques.Pocion());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 5:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        variable1.Heroe(ataques.BendicionSagrada());
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Dolor());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 6:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.MaestroEspadas());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 7:
                        variable1.Heroe(ataques.DefensaAbsoluta(ataques.AtqEnemigo()));
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Cargazo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 8:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Veneno());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 9:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Daga());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 10:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Furia());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    case 11:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.GolpeBajo());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                    default:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.HambrienTITO());
                        condatq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condatq);
                        historia.Limpieza();
                        break;
                }
                estadisticaEnemigo = condatq;
                Console.WriteLine(estadisticaP);
            }
            while (estadisticaEnemigo > 1);
        }

    }
}
