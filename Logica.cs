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
            /* bool valid; Borar códigos que no se usan.
               int opcion, condatq; estadisticaEnemigo */
            int saludHeroe, saludOrco = 100, saludLich = 150, saludDarkKnight = 180, saludWizard = 200, saludDarkDemonKing = 450;
            //Colocar todas las variables de 1 tipo sobre la misma linea de código.
            Personajes personajes = new Personajes();
            Historia historia = new Historia();
            CicloAtaque ciclo = new CicloAtaque();
            Ataques ataques = new Ataques();
            Enemigo variable2 = new Enemigo(saludOrco);
                                                        //Genero espacio para dejar una mejor lectura del código.
                                                        //Acomodo toda la declaración de variables al principio del código.
            historia.introduccion();
            historia.primerJefe();
            saludHeroe = personajes.retornoHeroe();
            ciclo.cicloAtaques(saludHeroe, saludOrco);
            historia.ganaBatalla();
            historia.segundoJefe();
            ciclo.cicloAtaques(saludHeroe, saludLich);
            historia.ganaBatalla();
            historia.tercerJefe();
            ciclo.cicloAtaques(saludHeroe, saludDarkKnight);
            historia.ganaBatalla();
            historia.cuartoJefe();
            ciclo.cicloAtaques(saludHeroe, saludWizard);
            historia.ganaBatalla();
            historia.reyDemonio();
            ciclo.cicloAtaques(saludHeroe, saludDarkDemonKing);
            historia.ganaBatallaFinal();
        }
    }    
}
