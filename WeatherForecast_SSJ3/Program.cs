using System;
using WeatherForecastLibreriaFINAL.Modelos;
using WeatherForecastLibreriaFINAL.Servicios;

class Program
{ 
    // Program para hacer las Pruebas y ver que Funcionen
    static void Main()
    {
        // Creo intancia de la Estacion
        EstacionMeteorologica estacion = new EstacionMeteorologica();

        // Creo personas para la estación
        var pasantes = new Pasante[]
        {
            new Pasante { Nombre = "Miguel", Apellido = "Merentiel", NumeroLegajo = "L001" },
            new Pasante { Nombre = "Ezequiel", Apellido = "Fernandez", NumeroLegajo = "L002" },
            new Pasante { Nombre = "Luis", Apellido = "Advincula", NumeroLegajo = "L003" }
        };

        var profesionales = new Profesional[]
        {
            new Profesional { Nombre = "Matias", Apellido = "Ramirez", NumeroMatricula = "M001" },
            new Profesional { Nombre = "Lionel", Apellido = "Messi", NumeroMatricula = "M002" },
            new Profesional { Nombre = "Diego", Apellido = "Maradona", NumeroMatricula = "M003" }
        };

        // FOR para crear registros de temperatura y registrarlos
        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                // Aca se alterna entre pasantes y profesionales
                var persona = (semana * 7 + dia) % 2 == 0
                    ? (Persona)pasantes[(semana * 7 + dia) / 2 % 3]
                    : (Persona)profesionales[(semana * 7 + dia) / 2 % 3];

                var registro = new RegistroTemperatura
                {
                    Temperatura = new Random().Next(-10, 40),
                    PersonaDeTurno = persona,
                    FechaRegistro = DateTime.Today.AddDays(semana * 7 + dia),
                    HoraRegistro = new TimeSpan((semana * 7 + dia) % 24, 0, 0)
                };

                estacion.RegistrarTemperatura(registro, semana, dia);
            }
        }

        // Realizar los Calculos para los Ejemplos
        var promedio = CalculoTemperaturas.CalcularPromedioTemperaturas(estacion.GetRegistros());
        var tempMaxima = CalculoTemperaturas.EncontrarTemperaturaMasAlta(estacion.GetRegistros());
        var tempMinima = CalculoTemperaturas.EncontrarTemperaturaMasBaja(estacion.GetRegistros());

        // Mostrar los Resultados en Consola
        Console.WriteLine($"Promedio de temperaturas: {promedio:F2}°C");
        Console.WriteLine($"Temperatura mas alta: {tempMaxima}°C");
        Console.WriteLine($"Temperatura mas baja: {tempMinima}°C");
    }
}
