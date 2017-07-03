using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        private XmlSerializer _serializer;

        public Xml()
        {
            this._serializer = new XmlSerializer(typeof(T));
        }

        public bool Guardar(string archivo, T datos)
        {

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    this._serializer.Serialize(writer, datos);
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        public bool Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    datos = (T)this._serializer.Deserialize(reader);
                    return true;
                }

            }
            catch (Exception e)
            {
                datos = default(T);
                throw new ArchivosException(e);
            }
        }
    }
}
