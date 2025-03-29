using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "M" };
            CapacidadTanque = 5;
            ConsumoCombustible = 0.05;
            VelocidadMaxima = 200;
            NivelCombustible = 4;
        }

        public string HacerCaballito()
        {
            if (estadoVehiculo == 2) 
            {
                return "La moto está haciendo un caballito!";
            }
            else
            {
                return "La moto debe estar en movimiento para hacer un caballito.";
            }
        }
    }
}