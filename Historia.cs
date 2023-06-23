using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_s_Quest
{
    public class Historia
    {
        string texto;
        int[] habilitados = new int[2];
        public void Limpieza() //sirve como un procedimiento para limpiar la pantalla entre cada punto de inflección de la historia.
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public void Introduccion()
        {
            int vel = 50;
            texto = " Esta es la historia de un caballero que salió de su casa puto por que le habían\r\n plagiado el escudo de armas de su linaje.\r\n Al ver que el malévolo Rey Demonio Oscuro había usurpado sus simbolos sin pagar regalías,\r\n fue directamente a hacer justicia a mano propia";
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void PrimerJefe()
        {
            int vel = 50;
            texto = " Al caminar hacia el castillo se topa con el primer jefe de área, un orco malhumorado.\r\n El caballero lo mira y le dice:\r\n \r\n -¡Perro!, ¿dónde está tú rey? \r\n -Necesito que me pague lo mío o acá va a ver muertos. \r\n \r\n El orco lo mira con cara de no saber que pasa pero el caballero muy enojado le dice una vez más: \r\n \r\n -ah sí que te haces el bobo, pues ahora te voy a dar lo tuyo desgraciado.\r\n \r\n Es ahora que empieza la batalla";
            Console.WriteLine("");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void SegundoJefe()
        {
            int vel = 50;
            texto = "Derrotado el primer jefe, nuestro vengativo caballero se dirige nuevamente al \r\n castillo del rey oscuro, pero… ¡oh! Sorpresa, se encuentra con el segundo jefe de área\r\n a lo que el caballero le grita:\r\n \r\n -¡Quítate o te volteo el mascadero!\r\n \r\n El segundo jefe apenas y tuvo tiempo para ver quien era\r\n y ya le estaban enviando la mano a la cara\r\n Es cuando el segundo encuentro comienza:";
            Console.WriteLine("");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void TercerJefe()
        {
            int vel = 50;
            texto = "Tras derrotar al segundo jefe, nuestro tierno y nada violento héroe sigue su\r\n búsqueda para cobrar regalías por la usurpación ilegal de su escudo de armas,\r\n cada vez más cerca del castillo esté se choca con accidentalmente con\r\n el otro jefe de área, una vez más el caballero gentilmente le dice:\r\n \r\n -¡Huevón!, ¿es que no tienes ojos o que?, sabes que… no me digas nada que te voy a dar una muenda para que aprendas.\r\n \r\n Así es como da comienzo al tercer combate.";
            Console.WriteLine("");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void CuartoJefe()
        {
            int vel = 50;
            texto = "Una vez derrotado el tercer jefe, nuestro amado caballero sigue su camino para ver\r\n al Rey Demonio Oscuro, está vez se encuentra con el cuarto jefe de área, pero\r\n esta vez siente curiosidad al verlo tan callado, a lo que él pregunta:\r\n \r\n -¿Por qué tan callado?, si quieres puedes decirme.\r\n \r\n Es cuando el cuarto jefe de área decide darle un “pequeño resumen” del por qué \r\n estaba callado… Después de escucharlo hablar por más de dos horas cosas como:\r\n \r\n -“sí caballero, mire que debe sacar el ponderado para tener el resultado”\r\n o\r\n -“no muchachos, ustedes no me entienden, venga les explico otra vez”\r\n \r\n El caballero no aguanto más y decidió callarlo de la manera que él sabía, a los trancazos.\r\n De nuevo empieza una épica batalla.";
            Console.WriteLine("");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void ReyDemonio()
        {
            int vel = 50;
            texto = "";
            Console.WriteLine("Una vez eliminado los 4 jefes, se dirige a ver al rey demonio oscuro,\r\n encontrados frente a frente el caballero dice:\r\n       - ¡Págame lo mío HP! (hewlett Packard). Mi plata, ¿dónde está?\r\n \r\n El Rey Demonio responde:\r\n \t       - Parce ¿sabe qué?, me lo mecatee en cositas.\r\n \r\n Es cuando la decisiva ultra mega contra hiper batalla final full HD, Real no Fake empieza:");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void Derrota()
        {
            Console.WriteLine("Te han derrotado, sos severo malo");
            Limpieza();
        }
        public void GanaBatalla()
        {
            Console.WriteLine("sos un capo, estás más cerca de recuperar lo que es tuyo");
            Limpieza();
        }
        public void GanaBatallaFinal()
        {
            Console.WriteLine("¡Lo conseguiste!, demostraste que el plagio nunca ganará...\r\n pero viendo de cerca ese no era tu escudo de armas,\r\n ahí es cuando el caballero decide irse lentamente antes que lo culpen por ese reguero de cuerpos en el piso.\r\n \r\n \r\n FIN.");
            Limpieza();
        }
        public void DerrotaBatallaFinal()
        {
            Console.WriteLine("nooo tas cagao, estuviste a punto de pasar el juego, \r\n ahora por malo te tocá volver a comenzar");
            Limpieza();
        }
        public int Ver1()
        {
            int val1 = habilitados[0];
            return val1;
        }
        public int Ver2()
        {
            int val2 = habilitados[1];
            return val2;
        }
        public int Ver3()
        {
            int val3 = habilitados[2];
            return val3;
        }

        //Se coloca la baraja como procedimientos dentro de historia para no generar conflicto con los ataques, y para que no sea estatico dentro de lógica
        public void Baraja()
        {
            Stack<int> pilaAtaques = new Stack<int>();
            Random alea = new Random();
            int numepre = 0, numepost;
            for (int i = 0; i < 3; i++)
            {
                numepost = alea.Next(1, 12);
                if (numepre == numepost)
                {
                    i--;
                }
                else
                {
                    habilitados[i] = numepost;
                    numepre = numepost;
                    pilaAtaques.Push(numepost);
                }
            }
            while (pilaAtaques.Count > 0)
            {
                int muestra = pilaAtaques.Pop();

                if (muestra == 1)
                {
                    Puño();
                }
                else if (muestra == 2)
                {
                    Espadazo();
                }
                else if (muestra == 3)
                {
                    Cargazo();
                }
                else if (muestra == 4)
                {
                    Pocion();
                }
                else if (muestra == 5)
                {
                    BendicionSagrada();
                }
                else if (muestra == 6)
                {
                    MaestroEspadas();
                }
                else if (muestra == 7)
                {
                    DefensaAbsoluta();
                }
                else if (muestra == 8)
                {
                    Veneno();
                }
                else if (muestra == 9)
                {
                    Daga();
                }
                else if (muestra == 10)
                {
                    Furia();
                }
                else if (muestra == 11)
                {
                    GolpeBajo();
                }
                else
                {
                    HambrienTITO();
                }
            }
        }

        // los siguientes procedimientos son para mostrar en pantalla la descripción del ataque o habilidad.
        public void Puño() //detalle de los ataques
        {
            Console.WriteLine("1) Puño: Da un patetico puño de. 5 atq");
        }
        public void Espadazo()
        {
            Console.WriteLine("2) Espadazo: 10 atq");
        }
        public void Cargazo()
        {
            Console.WriteLine("3) Cargazo: embiste tu enemigo. 8 atq");
        }
        public void Pocion()
        {
            Console.WriteLine("4) Poción: te curas. +5 de sangre");
        }
        public void BendicionSagrada()
        {
            Console.WriteLine("5) Bendición: te curas. +15 de sangre y causas dolor 5 atq ");
        }
        public void MaestroEspadas()
        {
            Console.WriteLine("6) Maestro de Espadas: ataque hecho por un profesional. +15 de atq");
        }
        public void DefensaAbsoluta()
        {
            Console.WriteLine("7) Defensa Absoluta. defensa +15");
        }
        public void Veneno()
        {
            Console.WriteLine("8) Veneno. daño progresivo por tres turnos -5");
        }
        public void Daga()
        {
            Console.WriteLine("9) Daga. +7 atq");
        }
        public void Furia()
        {
            Console.WriteLine("10) Furia. reduce la defensa -8");
        }
        public void GolpeBajo()
        {
            Console.WriteLine("11) Golpe en los bajos, que dolor de hue.. . +6 atq");
        }
        public void HambrienTITO()
        {
            Console.WriteLine("12) el TITO Mordelon: Muerde al rival, solo por que si. +7 atq");
        }
    }
}
