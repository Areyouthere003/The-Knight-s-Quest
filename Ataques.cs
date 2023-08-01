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
        private int numePre= 0, numePost;           //Cambio a CamelCase
                                                    //Colocamos espacios para hacer una mejor lectura del código.
        public Ataques() //constructor por defecto
        {
            for (int i = 1; i < 12; i++)
            {
                numePost = alea.Next(1, 12); ;
                if(numePre == numePost)
                {
                    i--;
                }
                else
                    pilaAtaques.Push(numePre);
            }
        }

       public int atqEnemigo()
        {
            numePost = alea.Next(1, 12);

            switch (numePost)
            {
                case 1:
                    return puño();
                case 2:
                    return espadazo();
                case 3:
                    return cargazo();
                case 4:
                    return puño();
                case 5:
                    return bendicionSagrada();
                case 6:
                    return maestroEspadas();
                case 7:
                    return cargazo();
                case 8:
                    return veneno();
                case 9:
                    return daga();
                case 10:
                    return furia();
                case 11:
                    return golpeBajo();
                default:
                    return hambrienTito();
            }
        }

        public string tipoAtaqueEnemigo()
        {
            switch (numePost)
            {
                case 1:
                    return "Enemigo ha usado Puño";
                case 2:
                    return "Enemigo ha usado Espadazo";
                case 3:
                    return "Enemigo ha usado Cargazo";
                case 4:
                    return "Enemigo te intentó aruñar";
                case 5:
                    return "Enemigo se equivoco y tiró una Poción Máxima +15 de Salud";
                case 6:
                    return "Enemigo ha usado Maestro de Espadas";
                case 7:
                    return "Enemigo ha usado Cargazo";
                case 8:
                    return "Enemigo ha intentado envenenarte";
                case 9:
                    return "Enemigo ha usado una Daga";
                case 10:
                    return "Enemigo arremete con Furia";
                case 11:
                    return "Enemigo te tira un golpe en los bajos";
                default:
                    return "Enemigo ha usado HAMBRIENTITO por ende se tambalea de hambre";
            }
        }

        public int puño() //ataque simpl
        {
            int puño = -5;
            return puño;
        }

        public int espadazo() //ataque con arma
        {
            int espadazo = -10;
            return espadazo;
        }

        public int cargazo()
        {
            int cargazo = -8;
            return cargazo;
        }

        public int pocion()
        {
            int pocion = 5;
            return pocion;
        }

        public int bendicionSagrada()
        {
            int bendicion = +15;
            return bendicion;
        }

        public int dolor()
        {
            int dolor = -5;
            return dolor;
        }

        public int maestroEspadas()
        {
            int maestro = -15;
            return maestro;
        }

        public int defensaAbsoluta(int atq)
        {
            int defensaAbsoluta = atq + 15;
            return defensaAbsoluta;
        }

        public int veneno()
        {
            int veneno = -5;
            return veneno;
        }

        public int daga()
        {
            return -7;
        }

        public int furia()
        {
            return -8;
        }
        
        public int golpeBajo()
        {
            return -6;
        }
        
        public int hambrienTito()
        {
            return -7;
        }
        
        public int pasivo()
        {
            return 0;
        }
    }
}
