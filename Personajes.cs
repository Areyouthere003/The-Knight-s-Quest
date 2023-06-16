using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    internal class Personajes
    {
        public class Enemigos
        {
            private int ataque;
            private int defensa;
            private int HP;

            public void VidaOrco()
            {
                HP = 100;
                ataque = 3;
                defensa = 2;
            }
        }
        public class Heroe
        {
            private int ataque;
            private int defensa;
            private int HP;
            public void Heroe1(int hp, int ataque, int defensa)
            {
                hp = 101;
                ataque = 4;
                defensa = 3;
                Console.WriteLine("{0}, {1}, {2}", hp, ataque, defensa);
            }
        }
    }
}
