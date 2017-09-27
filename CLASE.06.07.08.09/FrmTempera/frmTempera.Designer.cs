namespace FrmTempera
{
    partial class frmTempera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.cmbcolores = new System.Windows.Forms.ComboBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(21, 29);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(36, 13);
            this.lblmarca.TabIndex = 0;
            this.lblmarca.Text = "marca";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(21, 72);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(30, 13);
            this.lblcolor.TabIndex = 1;
            this.lblcolor.Text = "color";
            this.lblcolor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(21, 116);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(48, 13);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "cantidad";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(24, 49);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 3;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(24, 145);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 5;
            // 
            // cmbcolores
            // 
            this.cmbcolores.FormattingEnabled = true;
            this.cmbcolores.Location = new System.Drawing.Point(24, 88);
            this.cmbcolores.Name = "cmbcolores";
            this.cmbcolores.Size = new System.Drawing.Size(100, 21);
            this.cmbcolores.TabIndex = 6;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(24, 190);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 7;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(145, 190);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmTempera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 262);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.cmbcolores);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblmarca);
            this.Name = "frmTempera";
            this.Text = "frmTempera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.ComboBox cmbcolores;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}