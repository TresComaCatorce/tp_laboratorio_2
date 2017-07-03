using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        protected int _legajo;

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this._legajo = legajo;
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;

            if (pg1.GetType() == pg2.GetType() && ((pg1._legajo == pg2._legajo) || (pg1._dni == pg2._dni)))
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return (!(pg1 == pg2));
        }

        public override bool Equals(object o)
        {
            bool retorno = false;

            if (o is Universitario)
            {
                retorno = (this == (Universitario)o);
            }
            return retorno;

        }

        protected virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.ToString());
            retorno.AppendLine("Legajo: " + this._legajo.ToString());

            return retorno.ToString();

        }

        protected abstract string ParticiparEnClase();
    }
}
