using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class Cilindro : Figura
	{

		public double Radio { get; set; }
        public double Altura { get; set; }

		public Cilindro(double radio, double altura)
		{
			Radio = radio;
			Altura = altura;
		}

		public double CalcularVolumen()
		{
			return Math.PI * Math.Pow(Radio,2) * Altura ;
		}
        public override void MostrarMensaje()
		{
            Console.WriteLine($"Radio {Radio} -- Altura {Altura} -- Volument: {CalcularVolumen()}");
        }
	}
}
