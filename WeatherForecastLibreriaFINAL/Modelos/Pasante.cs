using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastLibreriaFINAL.Modelos
{
    // Clase que representa a un pasante, hereda de Persona sus cosas
    public class Pasante : Persona
    {
        // y suma Legajo
        public string NumeroLegajo { get; set; }
    }
}
