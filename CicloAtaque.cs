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

        public void cicloAtaques(int saludHeroe, int saludOrco) //Usar el PascalCase y CamelCase
        {
            Ataques ataques = new Ataques();
            Historia historia = new Historia();
            Personajes variable1 = new Personajes();
            Enemigo variable2 = new Enemigo(saludOrco);
            int heroe = variable1.retornoHeroe(), malo = variable2.retornoOrco();
            estadisticaEnemigo = saludOrco;
            condAtq = saludOrco;
            estadisticaP = saludHeroe;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("tu salud es: {0}", saludHeroe);
                Console.WriteLine("La salud del enemigo es: {0}", condAtq);
                Console.WriteLine("");
                historia.baraja();

                do
                {
                    Console.WriteLine("Escoja la carta (número)");
                    valid = int.TryParse(Console.ReadLine(), out opcion);

                    if (opcion > 0 && opcion < 13)
                    {
                        if (historia.verrificacion1() == opcion || historia.verificacion2() == opcion || historia.Ver3() == opcion)
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
                        variable1.heroe(ataques.atqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.puño());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 2:
                        variable1.heroe(ataques.atqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.espadazo());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 3:
                        variable1.heroe(ataques.atqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.cargazo());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 4:
                        variable1.heroe(ataques.atqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.pasivo());
                        variable1.heroe(ataques.pocion());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 5:
                        variable1.heroe(ataques.atqEnemigo());                    //Asigna el ataque del enemigo
                        variable1.heroe(ataques.bendicionSagrada());
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.dolor());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 6:
                        variable1.heroe(ataques.atqEnemigo());                    //Asigna el ataque del enemigo
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.maestroEspadas());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 7:
                        variable1.heroe(ataques.defensaAbsoluta(ataques.atqEnemigo()));
                        saludHeroe = variable1.retornoHeroe();              //devuelve el valor restante
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.cargazo());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 8:
                        variable1.heroe(ataques.atqEnemigo());
                        saludHeroe = variable1.retornoHeroe();
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.veneno());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 9:
                        variable1.heroe(ataques.atqEnemigo());
                        saludHeroe = variable1.retornoHeroe();
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.daga());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 10:
                        variable1.heroe(ataques.atqEnemigo());
                        saludHeroe = variable1.retornoHeroe();
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.furia());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    case 11:
                        variable1.heroe(ataques.atqEnemigo());
                        saludHeroe = variable1.retornoHeroe();
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.golpeBajo());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                    default:
                        variable1.heroe(ataques.atqEnemigo());
                        saludHeroe = variable1.retornoHeroe();
                        Console.WriteLine(ataques.tipoAtaqueEnemigo());
                        Console.WriteLine("tu salud es: {0}", saludHeroe);
                        estadisticaP = saludHeroe;
                        variable2.Orco(ataques.hambrienTito());
                        condAtq = variable2.retornoOrco();
                        Console.WriteLine("La salud de tu enemigo es: {0}", condAtq);
                        historia.limpieza();
                        break;

                }
                gameOver();
            }
            while (condAtq > 1);
        }

        private void gameOver()
        {
            Historia historia = new Historia();
            if (estadisticaP < 1)
            {
                Console.Clear();
                Console.WriteLine("La Cagaste y no alcanzaste a recuperar tu escudo de armas...");
                historia.derrota();
                Menu.menucito();
            }
        }
    }
}
