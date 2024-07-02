using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class Circulo : Figura, ICalculable
	{
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            this.Radio = radio;
        }
        public override void MostrarMensaje()
		{
            Console.WriteLine($"Radio: {Radio} -- Area: {CalcularArea()} -- Perimetro {CalcularPerimetro()}");
        }

		public double CalcularArea()
		{
			return  Math.PI * Math.Pow(Radio,2); // pi * radio al cuadrado, primero va la base y despues el exponente

		}

		public double CalcularPerimetro()
		{
			return 2*Math.PI * Radio;
		}
	}
}
