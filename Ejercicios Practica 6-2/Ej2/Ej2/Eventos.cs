using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ej2
{
    public class Eventos
    {
        public EventHandler<EventoCaracteres> EventoIngresoCaracter;

        public void AgregarCaracter(string letra)
        {
            string patron = @"[aeiou\s]";
            if (Regex.IsMatch(letra.ToLower(), patron))
            {
                this.EventoIngresoCaracter(this, new EventoCaracteres { vocal = letra });
            }
        }


    }

    public class EventoCaracteres
    {
        public string vocal { get; set; }
    }
}
