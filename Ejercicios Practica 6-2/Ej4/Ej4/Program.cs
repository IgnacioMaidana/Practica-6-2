using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Evento evento = new Evento();
            evento.Cambio += Handler;


        }

        static void Handler(object sender, AscensorArgs eventArgs)
        {

        }
    }
}
