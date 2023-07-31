using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class CicloAtaque
    {
        private int estadisticaEnemigo, estadisticaP, opcion, condAtq; //agrupar variables en una linea de código
        private bool valid; //realizar encapsulación, estaba en variable pública

        public void CicloAtaques(int saludHeroe, int saludOrco) //Usar el PascalCase y CamelCase
        {
            Ataques ataques = new Ataques();
            Historia historia = new Historia();
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(saludOrco);
            int heroe = variable1.RetornoHeroe(), malo = variable2.RetornoOrco();
            estadisticaEnemigo = saludOrco;
            condAtq = saludOrco;
            estadisticaP = saludHeroe;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("tu salud es: {0}", saludHeroe);
                Console.WriteLine("La salud del enemigo es: {0}", condAtq);
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
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Puño());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 2:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Espadazo());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 3:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Cargazo());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 4:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Pasivo());
                        variable1.Heroe(ataques.Pocion());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 5:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        variable1.Heroe(ataques.BendicionSagrada());
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Dolor());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 6:
                        variable1.Heroe(ataques.AtqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.MaestroEspadas());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 7:
                        variable1.Heroe(ataques.DefensaAbsoluta(ataques.AtqEnemigo()));
                        saludHeroe = variable1.RetornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Cargazo());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 8:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Veneno());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 9:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Daga());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 10:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.Furia());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    case 11:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.GolpeBajo());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                    default:
                        variable1.Heroe(ataques.AtqEnemigo());
                        saludHeroe = variable1.RetornoHeroe();
                        Console.WriteLine(ataques.TipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.HambrienTITO());
                        condAtq = variable2.RetornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.Limpieza();
                        break;

                }
                GameOver();
            }
            while (condAtq > 1);
        }

        private void GameOver()
        {
            Historia historia = new Historia();
            if (estadisticaP < 1)
            {
                Console.Clear();
                Console.WriteLine("La Cagaste y no alcanzaste a recuperar tu escudo de armas...");
                historia.Derrota();
                Menu.Menucito();
            }
        }
    }
}
