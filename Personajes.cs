using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class Personajes
    {
        private int ataque, defensa, hP, healthPointLeft, healthPointEnemy;

        //Constructor por defecto, se coloca como nombre el mismo nombre de la clase como por defecto
        public Personajes()
        {
            hP = 100;
            ataque = 3;
            defensa = 2;
        }
        public void Heroe(int daño)
        {
            hP -= daño;
        }
        public int RetornoHeroe()
        {
            return hP;
        }
    }
    public class Enemigo:Personajes
    {
        private int ataque1, defensa1, hP1, healthPointLeft1, healthPointEnemy1;
        public Enemigo(int healhtP, int atq, int def) 
        {
            hP1 = healhtP;
            ataque1 = atq;
            defensa1 = def;
        }
        public void Orco(int daño)
        {
            hP1 -= daño;
        }
        public int RetornoOrco()
        {
            return hP1;
        }
    }
}
