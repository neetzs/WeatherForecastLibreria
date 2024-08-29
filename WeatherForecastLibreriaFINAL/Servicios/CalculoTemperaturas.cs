using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastLibreriaFINAL.Modelos;

namespace WeatherForecastLibreriaFINAL.Servicios
{
    public static class CalculoTemperaturas
    {
        // Metodo para calcular el PROMEDIO de temperaturas en una coleccion de registros
        public static double CalcularPromedioTemperaturas(RegistroTemperatura[,] registros)
        {
            double suma = 0;
            int count = 0;

            for (int semana = 0; semana < 5; semana++)
            {
                for (int dia = 0; dia < 7; dia++)
                {
                    if (registros[semana, dia] != null)
                    {
                        suma += registros[semana, dia].Temperatura;
                        count++;
                    }
                }
            }

            return count > 0 ? suma / count : double.NaN;
        }

        //Metodo para encontrar la temperatura MAS ALTA en una coleccion de registros
        public static double EncontrarTemperaturaMasAlta(RegistroTemperatura[,] registros)
        {
            double tempMaxima = double.MinValue;

            for (int semana = 0; semana < 5; semana++)
            {
                for (int dia = 0; dia < 7; dia++)
                {
                    if (registros[semana, dia] != null && registros[semana, dia].Temperatura > tempMaxima)
                    {
                        tempMaxima = registros[semana, dia].Temperatura;
                    }
                }
            }

            return tempMaxima;
        }

        // Metodo para encontrar la temperatura MAS BAJA en una coleccion de registros
        public static double EncontrarTemperaturaMasBaja(RegistroTemperatura[,] registros)
        {
            double tempMinima = double.MaxValue;

            for (int semana = 0; semana < 5; semana++)
            {
                for (int dia = 0; dia < 7; dia++)
                {
                    if (registros[semana, dia] != null && registros[semana, dia].Temperatura < tempMinima)
                    {
                        tempMinima = registros[semana, dia].Temperatura;
                    }
                }
            }

            return tempMinima;
        }
    }
}
