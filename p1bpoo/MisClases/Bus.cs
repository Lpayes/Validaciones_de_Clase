using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Bus1 : Vehiculo
    {
        public int CapacidadPasajeros { get; }
        public int CantidadPasajerosActual { get; private set; }

        public Bus1(int anio, string elColor, string elModelo, int capacidadPasajeros) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A", "B" };
            CapacidadPasajeros = capacidadPasajeros;
            CantidadPasajerosActual = 0;
            CapacidadTanque = 79;
            ConsumoCombustible = 0.15;
            VelocidadMaxima = 100;
            NivelCombustible = 60;
        }

        public string SubirPasajeros(int cantidad)
        {
            if (CantidadPasajerosActual + cantidad > CapacidadPasajeros)
            {
                return "No se pueden subir más pasajeros, el bus está lleno.";
            }
            else
            {
                CantidadPasajerosActual += cantidad;
                return $"Pasajeros actuales: {CantidadPasajerosActual}";
            }
        }

        public string BajarPasajeros(int cantidad)
        {
            if (CantidadPasajerosActual - cantidad < 0)
            {
                return "No puedes bajar más pasajeros de los que hay.";
            }
            else
            {
                CantidadPasajerosActual -= cantidad;
                return $"Pasajeros actuales: {CantidadPasajerosActual}";
            }
        }
    }
}