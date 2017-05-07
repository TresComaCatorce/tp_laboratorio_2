using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
        private short _CantidadCalorias;

        public Dulce(EMarca marca, string codigoDeBarras, ConsoleColor color) : base(codigoDeBarras, marca, color)
        {
            this._CantidadCalorias = 80;
        }
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return this._CantidadCalorias;
            }
            set
            {
                this._CantidadCalorias = value;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine((string)this);
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
