namespace Interfaces_parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1 = new Auto(4, 200, 4);
            Auto a2 = new Auto(5, 500, 3);

            Bicicleta b1 = new Bicicleta(1, 20, 16);
            Bicicleta b2 = new Bicicleta(2, 30, 24);

            Moto m1 = new Moto(2, 150, 20);
            Moto m2 = new Moto(3, 200, 15);

            List<Transporte> listaMain = new List<Transporte>();
            
            listaMain.Add(a1);
            listaMain.Add(a2);
            listaMain.Add(b1);
            listaMain.Add(b2);
            listaMain.Add(m1);
            listaMain.Add(m2);

            //foreach(Transporte tr in listaMain)
            //{
            //    tr.Avanzar();
            //}

            foreach(Transporte tr in  listaMain)
            {
                if(tr is IEncendible)
                {
                    ((IEncendible)tr).Encender();
                }
            }

            //Garage miGarage = new Garage(listaMain);
            //miGarage.Serializar("vehiculos.xml"); //hay q poner un directorio
            
            Garage miGarage = new Garage();
            miGarage.Deserializar("vehiculos.xml"); //hay q poner un directorio

        }
    }
}
