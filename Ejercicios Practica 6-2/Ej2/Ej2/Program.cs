using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        public static List<string> Parrafo = new List<string>();
        static void Main(string[] args)
        {
            Eventos evento = new Eventos();
            evento.EventoIngresoCaracter += Handler;

            string letra = "-";
            Console.WriteLine("Redacte un parrafo una letra a la vez presionando enter para agregarla. Dejar en blanco para finalizar");
            do
            {
                letra = Console.ReadLine();
                evento.AgregarCaracter(letra);
            }
            while (letra != "");

            Console.WriteLine("Parrafo finalizado... Resultado: ");                     
            Console.WriteLine(string.Join("", Parrafo));
            
            Console.ReadLine();            
        }

        static void Handler(object sender, EventoCaracteres eventArgs)
        {
            Parrafo.Add(eventArgs.vocal);
        }
    }
}
