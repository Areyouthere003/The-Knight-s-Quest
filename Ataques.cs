using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class Ataques
    {
        public Stack<int> pilaAtaques = new Stack<int>();
        Random alea = new Random();
        private int numepre= 0, numepost;

        public Ataques() //constructor por defecto
        {
            for (int i = 1; i < 12; i++)
            {
                numepost = alea.Next(1, 12); ;
                if(numepre == numepost)
                {
                    i--;
                }
                else
                    pilaAtaques.Push(numepre);
            }
        }
       public int AtqEnemigo()
        {
            numepost = alea.Next(1, 12);
            switch (numepost)
            {
                case 1:
                    return Puño();
                case 2:
                    return Espadazo();
                case 3:
                    return Cargazo();
                case 4:
                    return Puño();
                case 5:
                    return BendicionSagrada();
                case 6:
                    return MaestroEspadas();
                case 7:
                    return Cargazo();
                case 8:
                    return Veneno();
                case 9:
                    return Daga();
                case 10:
                    return Furia();
                case 11:
                    return GolpeBajo();
                default:
                    return HambrienTITO();
            }
        }
        public int Puño() //ataque simpl
        {
            int puño = -5;
            return puño;
        }
        public int Espadazo() //ataque con arma
        {
            int espadazo = -10;
            return espadazo;
        }
        public int Cargazo()
        {
            int cargazo = -8;
            return cargazo;
        }
        public int Pocion()
        {
            int pocion = 5;
            return pocion;
        }
        public int BendicionSagrada()
        {
            int bendicion = +15;
            return bendicion;
        }
        public int Dolor()
        {
            int dolor = -5;
            return dolor;
        }
        public int MaestroEspadas()
        {
            int maestro = -15;
            return maestro;
        }
        public int DefensaAbsoluta(int atq)
        {
            int defensaAbsoluta = atq + 15;
            return defensaAbsoluta;
        }
        public int Veneno()
        {
            int veneno = -5;
            return veneno;
        }
        public int Daga()
        {
            return -7;
        }
        public int Furia()
        {
            return -8;
        }
        public int GolpeBajo()
        {
            return -6;
        }
        public int HambrienTITO()
        {
            return -7;
        }
        public int Pasivo()
        {
            return 0;
        }
    }
}
