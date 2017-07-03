namespace Layout
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.tbx_Operando1 = new System.Windows.Forms.TextBox();
            this.tbx_Operando2 = new System.Windows.Forms.TextBox();
            this.cbx_Operador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(13, 13);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(36, 39);
            this.lbl_Resultado.TabIndex = 0;
            this.lbl_Resultado.Text = "0";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(16, 129);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(290, 46);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "CC";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.BackColor = System.Drawing.Color.Green;
            this.btn_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Result.Location = new System.Drawing.Point(312, 129);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(255, 46);
            this.btn_Result.TabIndex = 2;
            this.btn_Result.Text = "=";
            this.btn_Result.UseVisualStyleBackColor = false;
            this.btn_Result.Click += new System.EventHandler(this.btn_Result_Click);
            // 
            // tbx_Operando1
            // 
            this.tbx_Operando1.Location = new System.Drawing.Point(16, 69);
            this.tbx_Operando1.Name = "tbx_Operando1";
            this.tbx_Operando1.Size = new System.Drawing.Size(158, 20);
            this.tbx_Operando1.TabIndex = 3;
            // 
            // tbx_Operando2
            // 
            this.tbx_Operando2.Location = new System.Drawing.Point(416, 69);
            this.tbx_Operando2.Name = "tbx_Operando2";
            this.tbx_Operando2.Size = new System.Drawing.Size(151, 20);
            this.tbx_Operando2.TabIndex = 4;
            // 
            // cbx_Operador
            // 
            this.cbx_Operador.FormattingEnabled = true;
            this.cbx_Operador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbx_Operador.Location = new System.Drawing.Point(233, 68);
            this.cbx_Operador.Name = "cbx_Operador";
            this.cbx_Operador.Size = new System.Drawing.Size(121, 21);
            this.cbx_Operador.TabIndex = 5;
            this.cbx_Operador.Text = "+";
            this.cbx_Operador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 187);
            this.Controls.Add(this.cbx_Operador);
            this.Controls.Add(this.tbx_Operando2);
            this.Controls.Add(this.tbx_Operando1);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Resultado);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora - Ferrero Cristian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Result;
        private System.Windows.Forms.TextBox tbx_Operando1;
        private System.Windows.Forms.TextBox tbx_Operando2;
        private System.Windows.Forms.ComboBox cbx_Operador;
    }
}

