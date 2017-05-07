using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Snacks : Producto
    {
        private short _cantidadCalorias;



        public Snacks(EMarca marca, string codigoDeBarras, ConsoleColor color) : base(codigoDeBarras, marca, color)
        {
            this._cantidadCalorias = 104;
        }



        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return this._cantidadCalorias;
            }
            set
            {
                this._cantidadCalorias = value;
            }
        }



        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine((string)this);
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
