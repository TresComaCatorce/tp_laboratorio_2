using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Collections;
using System.Xml.Serialization;
using Archivos;

namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> _clasesDelDia;
        private static Random _random;


        static Profesor()
        {
            Profesor._random = new Random();
        }

        public Profesor()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        private void _randomClases()
        {
            this._clasesDelDia.Enqueue((Universidad.EClases)Profesor._random.Next(3));
            this._clasesDelDia.Enqueue((Universidad.EClases)Profesor._random.Next(3));
        }


        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.MostrarDatos());
            retorno.AppendLine(this.ParticiparEnClase());

            return retorno.ToString();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Clases del día: ");

            foreach (Universidad.EClases i in this._clasesDelDia)
            {
                retorno.AppendLine(i.ToString());
            }

            return retorno.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }


        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach (Universidad.EClases j in i._clasesDelDia)
            {
                if (j == clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;

        }


        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return (!(i == clase));
        }
    }
}
