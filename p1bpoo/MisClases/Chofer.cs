using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        private string tipoLicencia;
        public string TipoLicencia
        {
            get => tipoLicencia;
            set
            {
                ValidarEdadLicencia(Edad, value);
                tipoLicencia = value;
            }
        }

        public Chofer(string name, int laEdad, string licenciaT)
        {
            ValidarEdadLicencia(laEdad, licenciaT);

            Nombre = name ?? throw new ArgumentNullException(nameof(name));
            Edad = laEdad;
            tipoLicencia = licenciaT ?? throw new ArgumentNullException(nameof(licenciaT));
        }

        private void ValidarEdadLicencia(int edad, string tipoLicencia)
        {
            if ((tipoLicencia == "M" || tipoLicencia == "C") && edad < 16)
            {
                throw new ArgumentException("Para las licencias tipo M y C, la edad mínima es 16 años.");
            }
            if (tipoLicencia == "B" && edad < 18)
            {
                throw new ArgumentException("Para la licencia tipo B, la edad mínima es 18 años.");
            }
            if (tipoLicencia == "A" && edad < 23)
            {
                throw new ArgumentException("Para la licencia tipo A, la edad mínima es 23 años.");
            }
        }

        public void mostrarInformación()
        {
            Console.WriteLine($"El piloto es {Nombre}");
            Console.WriteLine($"Licencia tipo {TipoLicencia}");
        }
    }
}