using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interfaces_parte2
{
    [Serializable]
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Bicicleta))]
    // hay que decir q la clase transporte incluye los tipos derivados
    public class Transporte
    {
        int cantidadPasajeros;
        float velocidadMaxima;

        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }
        public float VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }
        
        public Transporte(int cantidadPasajeros, float velocidadMaxima)
        {
            CantidadPasajeros = cantidadPasajeros;
            VelocidadMaxima = velocidadMaxima;
        }
        public Transporte()
        {
            
        }

        public virtual void Frenar()
        {
            Console.WriteLine("esta frenado");
        }

        public virtual void Avanzar()
        {
            Console.WriteLine("esta avanzando");
        }

        public override string ToString()
        {
            return $"{this.cantidadPasajeros}--{this.velocidadMaxima}";
        }


    }
}
