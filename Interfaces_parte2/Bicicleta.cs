using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_parte2
{
    [Serializable]
    public class Bicicleta : Transporte
    {
        int cambios;

        public int Puertas { get => cambios; set => cambios = value; }
        public Bicicleta(int cantidad, float velocidad, int cambios) : base(cantidad, velocidad)
        {
            this.cambios = cambios;
        }
        public Bicicleta() // esto es para serializar
        {
            
        }

        public override void Avanzar()
        {
            Console.WriteLine("La bicicleta ");
            base.Avanzar();
        }

        public override void Frenar()
        {
            Console.WriteLine("La bicicleta ");
            base.Frenar();
        }

        public override string ToString()
        {
            return base.ToString() + $"--{this.cambios}";
        }
    }
}
