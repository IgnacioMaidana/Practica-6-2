using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();           
            
            auto.SuperoVelocidadMax += Handler;

            Console.WriteLine("Auto Simulator");
            Console.WriteLine("Que desea realizar? (0-Terminar / 1-Arrancar / 2- ModificarVelocidad)");
            bool flag = true;

            while (flag)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Estado del auto" + (auto.Arrancar()? ": Encendido" : ": Apagado"));
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese la nueva velocidad");                        
                        auto.ModificarVelocidad(int.Parse(Console.ReadLine()));                        
                        break;
                    case 0:
                        flag = false;
                        break;
                }

                Console.WriteLine("Desea realizar otra operacion? (0-Terminar / 1-Arrancar / 2- ModificarVelocidad)");
                
            }

            Console.Clear();
            Console.WriteLine("Fin tara tatan");
            Console.ReadLine();
        }

        static void Handler(object sender, VelocidadArgs eventArgs)
        {
            Console.WriteLine($"Se supero la velocidad maxima de {eventArgs.velocidadMax} con una velocidad de {eventArgs.velocidadActual}");
        }
    }
}
