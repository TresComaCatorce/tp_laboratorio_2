using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Text.RegularExpressions;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        protected string _apellido;
        protected int _dni;
        protected ENacionalidad _nacionalidad;
        protected string _nombre;


        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = ValidarNombreApellido(value); }
        }

        public int DNI
        {
            get { return this._dni; }
            set { this._dni = ValidarDni(this.Nacionalidad, value); }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = ValidarNombreApellido(value); }
        }

        public string StringToDNI
        {
            set
            {
                try
                {
                    this._dni = ValidarDni(this.Nacionalidad, value);
                }
                catch
                {
                    throw new NacionalidadInvalidaException();
                }
            }
        }


        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }


        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("Nombre Completo: " + this.Apellido + ", " + this.Nombre);
            retorno.AppendLine("Nacionalidad: " + this.Nacionalidad);

            return retorno.ToString();
        }

        protected int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Extranjero:
                    {
                        if (dato > 89999999 && dato < 100000000)
                        {
                            return dato;
                        }
                        else
                        {
                            throw new NacionalidadInvalidaException("La nacionalidad y el número no coinciden.");
                        }
                    }

                case ENacionalidad.Argentino:
                    {
                        if (dato > 0 && dato <= 89999999)
                        {
                            return dato;
                        }
                        else
                        {
                            throw new NacionalidadInvalidaException("El número sobrepasa el máximo.");
                        }
                    }
            }

            throw new DniInvalidoException("El número está por debajo del minimo.");
        }

        protected int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno;
            if (!int.TryParse(dato, out retorno))
            {
                throw new DniInvalidoException("El número de DNI contiene caracteres invalidos");
            }
             
            return ValidarDni(nacionalidad, retorno);
        }

        protected string ValidarNombreApellido(string dato)
        {
            Regex rx = new Regex("^[A-Za-z]+$");

            if (rx.IsMatch(dato))
            {
                return dato;
            }

            return "";
        }

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
