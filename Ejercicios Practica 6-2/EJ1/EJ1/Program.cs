using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static bool flag = true;

        static void Main(string[] args)
        {
            Eventos evento = new Eventos();
            evento.rngSuperaPromedio += Handler;

            while (flag)
            {
                evento.AgregarNumero();
            }

            Console.ReadLine();
        }

        static void Handler(object sender, EventoRng eventArgs)
        {
            Dictionary<int, int> diccionario = new Dictionary<int, int>();
            foreach (int num in Lista.ListaRandom)
            {
                if (diccionario.ContainsKey(num))
                    diccionario[num]++;
                else
                    diccionario.Add(num, 1);                
            }
            Console.WriteLine($"El numero {eventArgs.numero} es menor que el promedio de {eventArgs.promedio} de la lista:");
            foreach (var num in diccionario)
            {
                Console.WriteLine($"({num.Key} : {num.Value}) - ");
            }
            flag = false;
            Console.WriteLine();
        }
    }
}
