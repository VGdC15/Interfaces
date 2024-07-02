using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Interfaces_parte2
{
    public class Garage:ISerializable
    {
        public List<Transporte> lista;
        public Garage()
        {
            
        }
        public Garage(List<Transporte>lista)
        {
            this.lista = lista;
        }

        //no se serializan atributos privados o protegidos
        //el metodo q se encarga de serializar va a tomar propiedades de lectura y escritura
        //tengo q tener un constructor por defecto q tiene q ser explicito
        // tiene q tener un cosntructor por defecto xq cuando quiera deserializar voy a estar trayendo un objeto
        // entonces necesito q se cree un espacio de memoria vacio para q se pueda ubicar ahi el objeto
        // las clases a serializar tienen q ser publicas
        public void Deserializar(string path)
        {
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer des = new XmlSerializer(typeof(List<Transporte>));
                    this.lista = (List<Transporte>)des.Deserialize(sr);

                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Serializar(string path)
        {
            try
            {
                //este administrador de ocntexto se va a encargar de 
                //crear un objeto q represente el string de datos entre el programa y el archivo
                using(StreamWriter sw = new StreamWriter(path))
                {
                    //ahora necesito un objeto q sepa escribir en un archivo xhml
                    XmlSerializer ser = new XmlSerializer(typeof(List<Transporte>));
                    ser.Serialize(sw, this.lista);

                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    
}
