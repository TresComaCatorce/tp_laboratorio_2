using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Xml.Serialization;
using Archivos;

namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;


        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }


        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.MostrarDatos());
            retorno.AppendLine(this.ParticiparEnClase());
            retorno.AppendLine("Estado de cuenta: " + this._estadoCuenta.ToString());

            return retorno.ToString();
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if (a._claseQueToma == clase && a._estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (!(a == clase));
        }


        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Toma clase de: " + this._claseQueToma.ToString());

            return retorno.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }


        public enum EEstadoCuenta
        {
            Deudor,
            Becado,
            AlDia
        }

    }
}
