using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        protected int velocidad { get; set; } = 0;

        //atributos nuevos
        protected List<string> tiposLicenciaAceptados = new() { "A", "B", "C", "M" };
        protected int VelocidadMaxima { get; set; }
        protected double CapacidadTanque { get; set; } // Capacidad del tanque de combustible (en galones)
        protected double ConsumoCombustible { get; set; } // Consumo de combustible por kilómetro (en galones/km)
        protected double NivelCombustible { get; set; } // Nivel actual de combustible en el tanque

        private Chofer? piloto = null;

        public int estadoVehiculo = 0; // 0= apagado, 1=encendido, 2= en movimiento

        public string AsignarPiloto(Chofer elPiloto)
        {
            if (elPiloto == null)
            {
                return "No se puede asignar un piloto nulo";
            }

            if (!tiposLicenciaAceptados.Contains(elPiloto.TipoLicencia))
            {
                return "El piloto no tiene el tipo de licencia adecuado para este vehiculo";
            }
            if (piloto != null)
            {
                return "Ya tiene un piloto asignado";
            }
            piloto = elPiloto;
            return "Piloto asignado exitosamente";
        }

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public string InformacionVehiculo()
        {
            string estado = estadoVehiculo switch
            {
                0 => "apagado",
                1 => "encendido",
                2 => "en movimiento",
                _ => "desconocido"
            };

            string infoPiloto = piloto != null ? piloto.Nombre : "No hay piloto asignado";

            return $"Color: {this.Color}, Modelo: {this.Modelo}, Año: {this.Year}, " +
                   $"Velocidad actual: {this.velocidad} km/h, Velocidad máxima: {this.VelocidadMaxima} km/h, " +
                   $"Estado del vehículo: {estado}, Piloto asignado: {infoPiloto}";
        }

        public string Encender()
        {
            if (piloto == null)
            {
                return "No puedes encender el carro sin piloto";
            }
            if (estadoVehiculo == 1)
            {
                return "El carro ya esta encendido";
            }
            estadoVehiculo = 1;
            return "El carro se ha encendido";
        }

        public virtual string Acelerar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (cuanto < 0)
                {
                    return "No se puede acelerar a una velocidad negativa";
                }
                if (velocidad + cuanto > VelocidadMaxima)
                {
                    velocidad = VelocidadMaxima;
                    return $"¡Alerta! No se puede superar la velocidad máxima de {VelocidadMaxima} km/h.";
                }
                else
                {
                    double combustibleNecesario = cuanto * ConsumoCombustible;
                    if (NivelCombustible < combustibleNecesario)
                    {
                        return "No hay suficiente combustible para acelerar";
                    }
                    velocidad += cuanto;
                    NivelCombustible -= combustibleNecesario;
                    return $"Vas a {velocidad} KMS / Hora. Nivel de combustible: {NivelCombustible} galones";
                }
            }
            else
            {
                return "No se puede acelerar un carro apagado";
            }
        }

        public string Frenar(int cuanto)
        {
            if (estadoVehiculo == 1)
            {
                if (cuanto < 0)
                {
                    return "No se puede frenar con un valor negativo";
                }
                if (velocidad - cuanto <= 0)
                {
                    velocidad = 0;
                    estadoVehiculo = 1;
                    return "El vehículo se ha detenido";
                }
                else
                {
                    velocidad -= cuanto;
                    return $"Vas a {velocidad} KMS / Hora";
                }
            }
            else
            {
                return "No se puede frenar un carro apagado";
            }
        }

        public string Apagar()
        {
            if (velocidad != 0)
            {
                return "No se puede apagar el vehículo en movimiento.";
            }
            if (estadoVehiculo == 0)
            {
                return "El vehículo ya está apagado";
            }
            estadoVehiculo = 0;
            return "El vehículo se ha apagado";
        }
    }
}