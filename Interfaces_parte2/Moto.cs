using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_parte2
{
    [Serializable] //hay q agregar esta etiqueta indicando q la clase es serializable
    public class Moto : Transporte, IEncendible
    {
        int cilindrada;

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public Moto(int cantidad, float velocidad, int cilindrada):base(cantidad, velocidad)
        {
            this.cilindrada = cilindrada;
        }
        public Moto() // esto es para serializar
        {
            
        }

        public override void Avanzar()
        {
            Console.WriteLine("La moto ");
            base.Avanzar();
        }

        public override void Frenar()
        {
            Console.WriteLine("La moto ");
            base.Frenar();
        }

        public override string ToString()
        {
            return base.ToString() + $"--{this.cilindrada}";
        }

        public void Encender()
        {
            Console.WriteLine("La moto se esta encendiendo");
        }

        public void Apagar()
        {
            Console.WriteLine("La moto se esta apagando");
        }
    }
}
