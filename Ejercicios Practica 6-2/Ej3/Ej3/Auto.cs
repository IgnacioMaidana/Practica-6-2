using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    public delegate bool DelegadoArrancar();//??  
    public delegate bool DelegadoVelocidad(int velocidad);

    public class Auto
    {
        public EventHandler<VelocidadArgs> SuperoVelocidadMax;

        private bool Encendido { get; set; }
        private int VelocidadActual { get; set; }
        private int VelocidadMaxima { get; set; }

        public Auto()
        {
            Encendido = false;
            VelocidadActual = 0;
            VelocidadMaxima = 100;
        }

        private bool Encender()
        {
            if (!Encendido) Encendido = true;
            return true;
        }

        private bool Apagar ()
        {
            if (Encendido) Encendido = false;
            return false;
        }

        private bool SubirVelocidad(int velocidad)
        {
            this.VelocidadActual = velocidad;
            if (velocidad > VelocidadMaxima)            
                this.SuperoVelocidadMax(this, new VelocidadArgs { velocidadMax = VelocidadMaxima, velocidadActual = velocidad });
            
            return true;
        }

        private bool BajarVelocidad(int velocidad)
        {
            this.VelocidadActual = velocidad;

            if (velocidad == 0)
                Apagar();
            
            return true;
        }


        public bool Arrancar()
        {
            DelegadoArrancar delegadoArrancar = !this.Encendido ? new DelegadoArrancar(Encender) : new DelegadoArrancar(Apagar);
            return delegadoArrancar();
        }

        public void ModificarVelocidad(int velocidad)
        {
            DelegadoVelocidad delegadoVelocidad;
            if (velocidad >= VelocidadActual)
                delegadoVelocidad = new DelegadoVelocidad(SubirVelocidad);
            else
                delegadoVelocidad = new DelegadoVelocidad(BajarVelocidad);

            delegadoVelocidad(velocidad);
        }

    }

    public class VelocidadArgs : EventArgs
    {
        public int velocidadMax { get; set; }
        public int velocidadActual { get; set; }
    }
}
