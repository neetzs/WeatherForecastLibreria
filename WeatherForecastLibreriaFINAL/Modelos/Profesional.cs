using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastLibreriaFINAL.Modelos
{
    // Clase que representa a un profesional, hereda de Persona y tambien sus cosas
    public class Profesional : Persona
    {
        // Cambiando Legajo por Matricula
        public string NumeroMatricula { get; set; }
    }
}
