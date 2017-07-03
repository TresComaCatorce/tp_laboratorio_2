using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;


namespace Archivos
{
    public class Texto
    {
        /// <summary>
        /// Guarda un archivo de texto en la ruta especificada y con los datos también provistos.
        /// </summary>
        /// <param name="archivo"> [string] path o ruta del archivo a guardar. </param>
        /// <param name="datos"> [string] texto a guardar en el archivo. </param>
        /// <returns>'true' si se logró crear el archivo correctamente.</returns>
        public bool Guardar(string path, string data)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(data);
                }
                retorno = true;

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return retorno;
        }



        /// <summary>
        /// Lee un archivo de texto en la ruta especificada.
        /// </summary>
        /// <param name="archivo"> [string] path o ruta del archivo a leer. </param>
        /// <param name="datos"> [out string] salida por la que se muestra el resultado. </param>
        /// <returns>'true' si se logró leer el archivo correctamente.</returns>
        public bool Leer(string path, out string data)
        {
            bool retorno = false;
            try
            {
                using (StreamReader sr = new StreamReader(path, true))
                {
                    data = sr.ReadToEnd();
                }
                retorno = true;
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                data = "";
                return false;
            }
            return retorno;
        }
    }
}
