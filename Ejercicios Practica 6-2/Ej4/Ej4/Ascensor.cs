using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Ascensor
    {
        public EventHandler<AscensorArgs> Cambio;

        private int PisoActual { get; set; }

        private void subirPiso()
        {
            PisoActual++;
            //evento
        }

        private void bajarPiso()
        {
            PisoActual--;
            //evento
        }

        public int LlamarAscensor(int pisoActual)
        {
            return PisoActual - pisoActual; //devuelve la cantidad de pisos de diferencia
        }

        public void DefinirPiso(int pisoNuevo)
        {
            //usar subir o bajar 
        }

    }

    public class AscensorArgs
    {
        public int numeroPiso { get; set; }
    }
}
