using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_parte2
{
    [Serializable]
    public class Auto : Transporte, IEncendible
    {
        int puertas;

        public int Puertas { get => puertas; set => puertas = value; }
        public Auto(int cantidad, float velocidad, int puertas) : base(cantidad, velocidad)
        {
            this.puertas = puertas;
        }

        public override void Avanzar()
        {
            Console.WriteLine("El auto ");
            base.Avanzar();
        }

        public override void Frenar()
        {
            Console.WriteLine("El auto ");
            base.Frenar();
        }

        public override string ToString()
        {
            return base.ToString() + $"--{this.puertas}";
        }
        public Auto() // esto es para serializar
        {
            
        }

        public void Encender()
        {
            Console.WriteLine("El auto se esta encendiendo");
        }

        public void Apagar()
        {
            Console.WriteLine("El auto se esta apagando");
        }
    }
}
