using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastLibreriaFINAL.Modelos;

namespace WeatherForecastLibreriaFINAL.Servicios
{
    public class EstacionMeteorologica
    {
        private RegistroTemperatura[,] registros;

        // Constructor que inicia la matriz de los registros
        public EstacionMeteorologica()
        {
            registros = new RegistroTemperatura[5, 7]; // 5 semanas x 7 dias
        }

        // Metodo para registrar una temperatura especifica
        public void RegistrarTemperatura(RegistroTemperatura registro, int semana, int dia)
        {
            if (semana >= 0 && semana < 5 && dia >= 0 && dia < 7)
            {
                registros[semana, dia] = registro;
            }
            else // Validacion si da error
            {
                
                throw new ArgumentException("Semana o dia fuera de rango");
            }
        }

        // Metodo para obtener las temperaturas de una semana en especifico
        public double[] VerTemperaturas(int semana)
        {
            if (semana < 0 || semana >= 5)
                throw new ArgumentException("Semana fuera de rango");

            double[] temperaturas = new double[7];
            for (int dia = 0; dia < 7; dia++)
            {
                temperaturas[dia] = registros[semana, dia]?.Temperatura ?? double.NaN;
            }
            return temperaturas;
        }

        // Metodo para obtener un registro de temperatura en especifico
        public RegistroTemperatura ObtenerRegistro(int semana, int dia)
        {
            if (semana >= 0 && semana < 5 && dia >= 0 && dia < 7)
            {
                return registros[semana, dia];
            }
            throw new ArgumentException("Semana o día fuera de rango.");
        }

        // Posible Metodo para "Carga Manual" 
        public void CargarRegistrosManualmente()
        {
            // Aca se puede implementar la carga manual si se quiore 
        }

        // Metodo para obtener todos los registros (puede servir para los calculos)
        public RegistroTemperatura[,] GetRegistros()
        {
            return registros;
        }
    }
}
