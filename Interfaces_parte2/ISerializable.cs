using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_parte2
{
    internal interface ISerializable
    {
        void Serializar(string path);
        void Deserializar(string path);
    }
}
