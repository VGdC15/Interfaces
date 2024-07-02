namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// variable de tipo abstracto -- objeto ...
			Figura c1 = new Circulo(3);
			Rectangulo r1 = new Rectangulo(2, 6); 
			Cilindro ci1 = new Cilindro(3, 5);

            //c1.MostrarMensaje();
            //r1.MostrarMensaje();

            Console.WriteLine("{0}", ((Circulo)c1).CalcularArea());
            Console.WriteLine("{0}", ((ICalculable)c1).CalcularArea());


			List<Figura> list = new List<Figura>()
			{
				c1,r1,ci1
			};

			foreach (Figura f in list)
			{
				f.MostrarMensaje();
			}

			Circulo c2 = new Circulo(3);
			// no me permite agregar C1 porque es una figura y no implementa ICalculable
			List<ICalculable> lista = new List<ICalculable>()
			{
				c2,r1
			};

			foreach (ICalculable f in lista)
			{
				Console.WriteLine(f.CalcularPerimetro());
			}

		}
	}
}
