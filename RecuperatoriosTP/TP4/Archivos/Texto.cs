using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        private string _nombreArchivo;

        public Texto(string archivo)
        {
            this._nombreArchivo = archivo;
        }

        public bool guardar(string datos)
        {
            try
            {
                using (StreamWriter SW = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + this._nombreArchivo, true))
                {
                    SW.WriteLine(datos);
                    SW.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool leer(out List<string> datos)
        {
            string aux;

            try
            {
                using (StreamReader SR = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + this._nombreArchivo))
                {
                    datos = new List<string>();

                    while( (aux=SR.ReadLine()) != null )
                    {
                        datos.Add(aux);
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
