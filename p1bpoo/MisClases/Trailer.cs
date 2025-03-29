using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Trailer : Vehiculo
    {
        public int Carga { get; private set; }
        public int CargaMaxima { get; }

        public Trailer(int anio, string elColor, string elModelo, int cargaMaxima) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
            CargaMaxima = cargaMaxima;
            Carga = 0;
            CapacidadTanque = 300; // Capacidad del tanque en galones
            ConsumoCombustible = 5; // Consumo de combustible en galones/km
            VelocidadMaxima = 120; // Velocidad máxima en km/h
        }

        public string Cargar(int cantidad)
        {
            if (Carga + cantidad > CargaMaxima)
            {
                return "No se puede cargar más allá de la capacidad máxima.";
            }
            Carga += cantidad;
            return $"Carga actual: {Carga}";
        }

        public string Descargar(int cantidad)
        {
            if (cantidad > Carga)
            {
                return "No se puede descargar más de lo que está cargado.";
            }
            Carga -= cantidad;
            return $"Carga actual: {Carga}";
        }

        public override string Acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                velocidad += cuanto - 3; // Decremento de 3 al acelerar
                if (velocidad > VelocidadMaxima)
                {
                    velocidad = VelocidadMaxima;
                }
                return $"El trailer va a {velocidad} KMS / Hora";
            }
            else
            {
                return "No se puede acelerar un trailer apagado";
            }
        }
    }
}