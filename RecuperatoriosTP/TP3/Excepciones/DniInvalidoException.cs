using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        private string mensajeBase;

        public DniInvalidoException(string mensaje, Exception e) : base (mensaje, e)
        {
        }

        public DniInvalidoException(string mensaje) : this ("DNI no válido", null)
        {
        }

        public DniInvalidoException(Exception e) : this ("DNI no válido", e)
        {
        }

        public DniInvalidoException() : this ("DNI no válido")
        {
        }
    }
}
