using System.ComponentModel.Design;
using System.Reflection.Emit;
using System.Threading;

namespace Knight_s_Quest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 40);
            Menucito1();
        }

        static bool Detector()
        {
            ConsoleKeyInfo teclas = new ConsoleKeyInfo();
            bool valor;
            char caracter;
            teclas = Console.ReadKey();
            caracter = teclas.KeyChar;
            if(char.IsWhiteSpace(caracter)) 
            {
                valor = false;
            }
            else
                valor = true;

            return valor;
        }
        static void Menucito1()
        {
            int tiempoEspera = 10;
            while (tiempoEspera > 1)
            {
                Console.WriteLine("         ****************************************************************************************");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *████████╗██╗░░██╗███████╗░░░██╗░░██╗███╗░░██╗██╗░██████╗░██╗░░██╗████████╗██╗░██████╗░*");
                Console.WriteLine("         *╚══██╔══╝██║░░██║██╔════╝░░░██║░██╔╝████╗░██║██║██╔════╝░██║░░██║╚══██╔══╝╚█║██╔════╝░*");
                Console.WriteLine("         *░░░██║░░░███████║█████╗░░░░░█████═╝░██╔██╗██║██║██║░░██╗░███████║░░░██║░░░░╚╝╚█████╗░░*");
                Console.WriteLine("         *░░░██║░░░██╔══██║██╔══╝░░░░░██╔═██╗░██║╚████║██║██║░░╚██╗██╔══██║░░░██║░░░░░░░╚═══██╗░*");
                Console.WriteLine("         *░░░██║░░░██║░░██║███████╗░░░██║░╚██╗██║░╚███║██║╚██████╔╝██║░░██║░░░██║░░░░░░██████╔╝░*");
                Console.WriteLine("         *░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░░░╚═════╝░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░██████╗░██╗░░░██╗███████╗░██████╗████████╗░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░██╔═══██╗██║░░░██║██╔════╝██╔════╝╚══██╔══╝░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░██║██╗██║██║░░░██║█████╗░░╚█████╗░░░░██║░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░╚██████╔╝██║░░░██║██╔══╝░░░╚═══██╗░░░██║░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═██╔═╝░╚██████╔╝███████╗██████╔╝░░░██║░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═╝░░░░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         ****************************************************************************************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

                int modulo = tiempoEspera % 2;
                if (modulo == 0)
                {
                    Console.WriteLine("                              PRESIONE CUALQUIER TECLA PARA COMENZAR");
                    tiempoEspera--;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("");
                    tiempoEspera--;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            if (tiempoEspera < 2)
            {
                Console.WriteLine("         ****************************************************************************************");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *████████╗██╗░░██╗███████╗░░░██╗░░██╗███╗░░██╗██╗░██████╗░██╗░░██╗████████╗██╗░██████╗░*");
                Console.WriteLine("         *╚══██╔══╝██║░░██║██╔════╝░░░██║░██╔╝████╗░██║██║██╔════╝░██║░░██║╚══██╔══╝╚█║██╔════╝░*");
                Console.WriteLine("         *░░░██║░░░███████║█████╗░░░░░█████═╝░██╔██╗██║██║██║░░██╗░███████║░░░██║░░░░╚╝╚█████╗░░*");
                Console.WriteLine("         *░░░██║░░░██╔══██║██╔══╝░░░░░██╔═██╗░██║╚████║██║██║░░╚██╗██╔══██║░░░██║░░░░░░░╚═══██╗░*");
                Console.WriteLine("         *░░░██║░░░██║░░██║███████╗░░░██║░╚██╗██║░╚███║██║╚██████╔╝██║░░██║░░░██║░░░░░░██████╔╝░*");
                Console.WriteLine("         *░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░░░░╚═════╝░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░██████╗░██╗░░░██╗███████╗░██████╗████████╗░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░██╔═══██╗██║░░░██║██╔════╝██╔════╝╚══██╔══╝░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░██║██╗██║██║░░░██║█████╗░░╚█████╗░░░░██║░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░╚██████╔╝██║░░░██║██╔══╝░░░╚═══██╗░░░██║░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═██╔═╝░╚██████╔╝███████╗██████╔╝░░░██║░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         *░░░░░░░░░░░░░░░░░░░░░░░░░░░░░╚═╝░░░░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░░░░░░░░░░░░░░░░░░*");
                Console.WriteLine("         ****************************************************************************************");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


                Console.WriteLine("                              PRESIONE CUALQUIER TECLA PARA COMENZAR");
                if (Detector() == true)
                {
                    Console.WriteLine("Exito"); //aqui vamos directo a la logica del juego se cambia 
                    Console.ReadKey();          //las variable de estas lineas por la llamada al juego
                }
                else
                {
                    Console.Clear();
                    Menucito1();
                }
            }
        }
    
    }
}
