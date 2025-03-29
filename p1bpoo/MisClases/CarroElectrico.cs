using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            cargaBateria = 50;
        }

        public override string Acelerar(int cuanto)
        {
            base.Acelerar(cuanto);
            cargaBateria--;
            string mensaje = $"El carro eléctrico ha acelerado {cuanto} unidades. Nivel de batería: {cargaBateria}";
            Console.WriteLine(mensaje);
            return mensaje;
        }

        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }
    }
}
