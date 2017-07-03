using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Layout
{
    public partial class frmCalculadora : Form
    {
        private Numero numero1;
        private Numero numero2;
        private string operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Limpia ambos operando, el operador y el resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.tbx_Operando1.ResetText();
            this.tbx_Operando2.ResetText();
            this.lbl_Resultado.Text = "0";
            this.cbx_Operador.Text = "+";
        }

        /// <summary>
        /// Realiza la operación indicada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Result_Click(object sender, EventArgs e)
        {
            this.numero1 = new Numero(tbx_Operando1.Text);
            this.numero2 = new Numero(tbx_Operando2.Text);
            this.operador = cbx_Operador.Text;

            this.lbl_Resultado.Text = ( Calculadora.Operar( this.numero1, this.numero2, Calculadora.validarOperador(this.operador) ) ).ToString() ;
        }




    }
}
