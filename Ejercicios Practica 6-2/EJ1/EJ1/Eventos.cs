using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class Eventos
    {
        public EventHandler<EventoRng> rngSuperaPromedio;
        Random randi = new Random();

        public void AgregarNumero()
        {
            int n = randi.Next(0, 100);
            Lista.ListaRandom.Add(n);
            double prom = Lista.ListaRandom.Average();
            if (prom > n)
            {
                this.rngSuperaPromedio(this, new EventoRng(){numero = n, promedio = prom});
            }
        }        
    }

    public class EventoRng
    {
        public int numero { get; set; }
        public double promedio { get; set; }
    }
}
