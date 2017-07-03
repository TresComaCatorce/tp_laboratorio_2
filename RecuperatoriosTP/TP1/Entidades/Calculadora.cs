using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        #region Métodos

        /// <summary>
        /// Realiza la operación indicada en el parámetro 'valor' entre los parámetros 'numero1' y 'numero2'.
        /// </summary>
        /// <param name="numero1">Operando.</param>
        /// <param name="numero2">Operando.</param>
        /// <param name="operador">Operador.</param>
        /// <returns>Retorna el resultado, 0 en caso de division por nulo</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double retorno = 0;

            if (operador == "+")
            {
                retorno = numero1.getNumero() + numero2.getNumero();
            }
            else if (operador == "-")
            {
                retorno = numero1.getNumero() - numero2.getNumero();
            }
            else if (operador == "*")
            {
                retorno = numero1.getNumero() * numero2.getNumero();
            }
            else if ((operador == "/") && (numero2.getNumero() != 0))
            {
                retorno = numero1.getNumero() / numero2.getNumero();
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el parámetro 'operador' sea válido.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Retorna el valor recibído si es válido, sino retorna el operador '+'</returns>
        public static string validarOperador(string operador)
        {
            string retorno = "+";

            if ( operador.Equals("-") || operador.Equals("*") || operador.Equals("/") )
            {
                retorno = operador;
            }

            return retorno;
        }

        #endregion
    }
}
