using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException(string mensaje) : base(mensaje)
        {
        }

        public NacionalidadInvalidaException() : this("La nacionalidad no es válida")
        {
        }
    }
}
