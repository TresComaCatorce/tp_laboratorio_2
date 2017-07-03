using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores

        /// <summary>
        /// Constructor sin parámetros que setea el valor del atributo 'numero' en 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor con un valor 'double' como parámetro.
        /// </summary>
        /// <param name="valor">Valor del tipo 'double' que se le asigna al atributo 'numero'.</param>
        public Numero(double numero) : this()
        {
            this.numero = numero; 
        }

        /// <summary>
        /// Constructor que recibe un 'string' como parámetro, lo valida y, de ser posible, lo asigna al atributo 'numero'.
        /// </summary>
        /// <param name="valor">Número en formato 'string'.</param>
        public Numero(string numero) : this()
        {
            this.setNumero(numero);
        }

        #endregion



        #region Métodos

        /// <summary>
        /// Método que recibe un string y retorna, validandolo, el valor en 'double' de ese string.
        /// </summary>
        /// <param name="numeroString">Número en formato string.</param>
        /// <returns>Valor convertido a double</returns>
        private static double validarNumero( string numeroString)
        {
            double retorno;

            if( !double.TryParse(numeroString, out retorno) )
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Método que settea el valor del atributo 'numero' recibiendo un string y validandolo.
        /// </summary>
        /// <param name="numero">Número en formato string a validar.</param>
        private void setNumero(string numero)
        {
            this.numero = Numero.validarNumero(numero);
        }

        /// <summary>
        /// Método que retorna el valor del atributo 'numero'.
        /// </summary>
        /// <returns>Valor en 'double' del atributo 'numero'.</returns>
        public double getNumero()
        {
            return this.numero;
        }

        #endregion

    }
}
