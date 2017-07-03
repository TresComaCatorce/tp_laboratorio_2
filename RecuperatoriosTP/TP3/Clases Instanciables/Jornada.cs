using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{

    [Serializable]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]
    public class Jornada
    {
        protected List<Alumno> _alumnos;
        protected Universidad.EClases _clase;
        protected Profesor _instructor;

        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        public Universidad.EClases Clase
        {
            get { return this._clase; }
            set { this._clase = value; }
        }

        public Profesor Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }

        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }

        public string Leer()
        {
            try
            {
                string retorno = "";
                Texto import = new Texto();
                import.Leer("Jornada.txt", out retorno);
                return retorno;
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }

        }

        public static bool Guardar(Jornada jornada)
        {
            try
            {
                Texto export = new Texto();
                export.Guardar("Jornada.txt", jornada.ToString());
                return true;
            }
            catch(Exception e)
            {
                throw new ArchivosException(e);
            }
            

        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Clase de " + this._clase);
            retorno.Append(" por " + this._instructor.ToString());
            retorno.AppendLine("Alumnos: ");

            foreach (Alumno j in this._alumnos)
            {
                retorno.Append(j);
            }
            
            retorno.AppendLine("<--------------------------------------------------------->");

            return retorno.ToString();
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno i in j._alumnos)
            {
                if (i == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return (!(j == a));
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (!(j == a))
            {
                j._alumnos.Add(a);
            }

            return j;
        }
    }
}
