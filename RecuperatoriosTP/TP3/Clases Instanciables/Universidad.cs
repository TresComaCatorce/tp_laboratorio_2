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
    [XmlInclude(typeof(Jornada))]
    public class Universidad
    {
        protected List<Alumno> alumnos;
        protected List<Jornada> jornadas;
        protected List<Profesor> profesores;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public Jornada this[int i]
        {
            get { return this.Jornadas[i]; }
            set { this.Jornadas[i] = value; }
        }

        public Universidad()
        {
            this.Alumnos = new List<Alumno>();
            this.Instructores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
        }

        public static bool Guardar(Universidad gim)
        {
            Xml<Universidad> export = new Xml<Universidad>();
            return export.Guardar("Universidad.xml", gim);

        }

        public static Universidad Leer(Universidad datos)
        {
            Xml<Universidad> import = new Xml<Universidad>();
            Universidad retorno;
            import.Leer("Universidad.xml", out retorno);
            return retorno;
        }

        private static string MostrarDatos(Universidad gim)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("JORNADA:");
            foreach (Jornada j in gim.jornadas)
            {
                retorno.Append(j);
            }

            return retorno.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);

        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;

            foreach (Alumno item in g.alumnos)
            {
                if (item == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return (!(g == a));
        }

        public static Profesor operator ==(Universidad g, Universidad.EClases clase)
        {
            foreach (Profesor item in g.profesores)
            {
                if (item == clase)
                {
                    if (!(object.Equals(item, null)))
                    {
                        return item;
                    }
                }
            }

            throw new SinProfesorException();
        }

        public static Profesor operator !=(Universidad g, Universidad.EClases clase)
        {
            foreach (Profesor item in g.profesores)
            {
                if (item != clase)
                {
                    return item;
                }
            }
            return null;
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;

            foreach (Profesor j in g.profesores)
            {
                if (i == j)
                {
                    retorno = true;
                }

            }

            return retorno;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return (!(g == i));
        }

        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g != a)
            {
                g.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }

            return g;
        }

        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g != i)
            {
                g.profesores.Add(i);
            }

            return g;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada aux = new Jornada(clase, (g == clase));

            foreach (Alumno t in g.alumnos)
            {
                if (t == clase)
                {
                    aux.Alumnos.Add(t);
                }

            }
            g.Jornadas.Add(aux);

            return g;

        }

        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    }
}
