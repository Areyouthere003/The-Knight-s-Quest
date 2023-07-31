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
            int saludHeroe, SaludOrco = 100, saludLich = 150, saludDarkKnight = 180, saludWizard = 200, saludDarkDemonKing = 450;
            //Colocar todas las variables de 1 tipo sobre la misma linea de código.
            Personajes variable1 = new Personajes();
            Historia historia = new Historia();
            CicloAtaque ciclo = new CicloAtaque();
            Ataques ataques = new Ataques();
            Enemigo variable2 = new Enemigo(SaludOrco);
                                                        //Genero espacio para dejar una mejor lectura del código.
                                                        //Acomodo toda la declaración de variables al principio del código.
            historia.Introduccion();
            historia.PrimerJefe();
            saludHeroe = variable1.RetornoHeroe();
            ciclo.CicloAtaques(saludHeroe, SaludOrco);
            historia.GanaBatalla();
            historia.SegundoJefe();
            ciclo.CicloAtaques(saludHeroe, saludLich);
            historia.GanaBatalla();
            historia.TercerJefe();
            ciclo.CicloAtaques(saludHeroe, saludDarkKnight);
            historia.GanaBatalla();
            historia.CuartoJefe();
            ciclo.CicloAtaques(saludHeroe, saludWizard);
            historia.GanaBatalla();
            historia.ReyDemonio();
            ciclo.CicloAtaques(saludHeroe, saludDarkDemonKing);
            historia.GanaBatallaFinal();
        }
    }    
}
