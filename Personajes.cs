using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class Personajes
    {
        private int pV; // ataque, defensa, healthPointLeft, healthPointEnemy; borrar variables sin uso

        //Constructor por defecto, se coloca como nombre el mismo nombre de la clase como por defecto para el héroe
        public Personajes()
        {
            pV = 50;
            /*ataque = 3; defensa = 2;      borrar variables isn uso */
        }

        public void heroe(int daño) //procedimiento para ir quitando sangre al héroe
        {
            pV += daño;
        }

        public int retornoHeroe() //método para llamar función y ver que tanta sagre le queda al héroe
        {
            return pV;
        }
    }
                                    //Agrego espacios para una mejor lectura del código.
    public class Enemigo:Personajes //Herencia de la clase personajes para los enemigos
    {
        private int Pv1; /* ataque1, defensa1, hP1, healthPointLeft1, healthPointEnemy1; Borrar código innecesario 
                            se agregan nuevas variables para cambiar la asignación de las que vienen por defecto */

        public Enemigo(int puntosSangre)  //Constructor parametrizado
        {
            Pv1 = puntosSangre;
        }

        public void Orco(int daño)
        {
            Pv1 += daño;
        }

        public int retornoOrco()
        {
            return Pv1;
        }
    }
}
