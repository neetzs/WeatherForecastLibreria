using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastLibreriaFINAL.Modelos
{
    // Clase que representa un registro de temperatura
    public class RegistroTemperatura
    {
        public double Temperatura { get; set; }
        public Persona PersonaDeTurno { get; set; }

        // DateTime estructura que representa un instante especifico en el tiempo
        public DateTime FechaRegistro { get; set; }

        // TimeSpan estructura que representa un intervalo de tiempo
        public TimeSpan HoraRegistro { get; set; }
    }

}
