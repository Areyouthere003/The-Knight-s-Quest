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
        private void Limpieza() //sirve como un procedimiento para limpiar la pantalla entre cada punto de inflección de la historia.
        {
            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public void Introduccion()
        {
            int vel = 100;
            texto = "Esta es la historia de un caballero que salió de su casa puto por que le habían plagiado el escudo de armas de su linaje. \r\n Al ver que el malévolo Rey Demonio Oscuro había usurpado sus simbolos sin pagar regalías, fue directamente a hacer justicia a mano propia";
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
        public void PrimerJefe()
        {
            int vel = 100;
            texto = "Al caminar hacia el castillo se topa con el primer jefe de área, un orco malhumorado. \r\n El caballero lo mira y le dice: ¡Perro!, ¿dónde está tú rey? \r\n Necesito que me pague lo mío o acá va a ver muertos. \r\n El orco lo mira con cara de no saber que pasa pero el caballero muy enojado le dice una vez más: \r\n ah sí que te haces el bobo, pues ahora te voy a dar lo tuyo desgraciado\r\n Es ahora que empieza la batalla";
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
            int vel = 100;
            texto = "Derrotado el primer jefe, nuestro vengativo caballero se dirige nuevamente al \r\n castillo del rey oscuro, pero… ¡oh! Sorpresa, se encuentra con el segundo jefe de área\r\n a lo que el caballero le grita:\r\n ¡Quítate o te volteo el mascadero!\r\n El segundo jefe apenas y tuvo tiempo para ver quien era\r\n y ya le estaban enviando la mano a la cara\r\n Es cuando el segundo encuentro comienza:";
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
            int vel = 100;
            texto = "Tras derrotar al segundo jefe, nuestro tierno y nada violento héroe sigue su \r\n búsqueda para cobrar regalías por la usurpación ilegal de su escudo de armas,\r\n cada vez más cerca del castillo esté se choca con accidentalmente con\r\n el otro jefe de área, una vez más el caballero gentilmente le dice:\r\n Huevón, ¿es que no tienes ojos o que?, sabes que… no me digas nada que te voy a dar una muenda para que aprendas.\r\n Así es como da comienzo al tercer combate.";
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
            int vel = 200;
            texto = "Una vez derrotado el tercer jefe, nuestro amado caballero sigue su camino a ver\r\n al Rey Demonio Oscuro, está vez se encuentra con el cuarto jefe de área, pero\r\n esta vez siente curiosidad al verlo tan callado, a lo que él pregunta:\r\n ¿Por qué tan callado?, si quieres puedes decirme.\r\n Es cuando el cuarto jefe de área decide darle un “pequeño resumen” de por qué \r\n estaba callado… Después de escucharlo hablar por más de dos horas cosas como:\r\n “sí caballero, mire que debe sacar el ponderado para tener el resultado”\r\n o\r\n “no muchachos, ustedes no me entienden, venga les explico otra vez”\r\n El caballero no aguanto y decidió callarlo de la manera que él sabía, a los trancazos.\r\n De nuevo empieza una épica batalla.";
            Console.WriteLine("");
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(vel);
            }
            Limpieza();
        }
    }
}
