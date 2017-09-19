namespace WINDOWNFORM
{
    partial class Form1
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
            this.btnsaludo = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsaludo
            // 
            this.btnsaludo.Location = new System.Drawing.Point(184, 36);
            this.btnsaludo.Name = "btnsaludo";
            this.btnsaludo.Size = new System.Drawing.Size(75, 23);
            this.btnsaludo.TabIndex = 0;
            this.btnsaludo.Text = "saludo";
            this.btnsaludo.UseVisualStyleBackColor = true;
            this.btnsaludo.Click += new System.EventHandler(this.btnsaludo_Click);
            // 
            // btnsalida
            // 
            this.btnsalida.Location = new System.Drawing.Point(184, 103);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(75, 23);
            this.btnsalida.TabIndex = 1;
            this.btnsalida.Text = "despedida";
            this.btnsalida.UseVisualStyleBackColor = true;
            this.btnsalida.Click += new System.EventHandler(this.btnsalida_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(29, 36);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(35, 13);
            this.lblmensaje.TabIndex = 2;
            this.lblmensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnsaludo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaludo;
        private System.Windows.Forms.Button btnsalida;
        private System.Windows.Forms.Label lblmensaje;
    }
}

