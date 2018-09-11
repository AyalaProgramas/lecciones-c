namespace _01_WINDOWNFORM
{
  partial class frmPantallaDos
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
            this.chkcheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbestudiante = new System.Windows.Forms.GroupBox();
            this.rdoargentino = new System.Windows.Forms.RadioButton();
            this.rdoextranjero = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txttexto = new System.Windows.Forms.TextBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.gbestudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkcheck
            // 
            this.chkcheck.AutoSize = true;
            this.chkcheck.Checked = true;
            this.chkcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkcheck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chkcheck.Location = new System.Drawing.Point(92, 31);
            this.chkcheck.Name = "chkcheck";
            this.chkcheck.Size = new System.Drawing.Size(65, 17);
            this.chkcheck.TabIndex = 0;
            this.chkcheck.Text = "chekear";
            this.chkcheck.UseVisualStyleBackColor = true;
            this.chkcheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbestudiante
            // 
            this.gbestudiante.Controls.Add(this.txttexto);
            this.gbestudiante.Controls.Add(this.rdoargentino);
            this.gbestudiante.Controls.Add(this.rdoextranjero);
            this.gbestudiante.Location = new System.Drawing.Point(74, 76);
            this.gbestudiante.Name = "gbestudiante";
            this.gbestudiante.Size = new System.Drawing.Size(200, 100);
            this.gbestudiante.TabIndex = 2;
            this.gbestudiante.TabStop = false;
            this.gbestudiante.Text = "estudiante";
            // 
            // rdoargentino
            // 
            this.rdoargentino.AutoSize = true;
            this.rdoargentino.Location = new System.Drawing.Point(27, 42);
            this.rdoargentino.Name = "rdoargentino";
            this.rdoargentino.Size = new System.Drawing.Size(85, 17);
            this.rdoargentino.TabIndex = 3;
            this.rdoargentino.TabStop = true;
            this.rdoargentino.Text = "radioButton1";
            this.rdoargentino.UseVisualStyleBackColor = true;
            // 
            // rdoextranjero
            // 
            this.rdoextranjero.AutoSize = true;
            this.rdoextranjero.Location = new System.Drawing.Point(27, 19);
            this.rdoextranjero.Name = "rdoextranjero";
            this.rdoextranjero.Size = new System.Drawing.Size(85, 17);
            this.rdoextranjero.TabIndex = 4;
            this.rdoextranjero.TabStop = true;
            this.rdoextranjero.Text = "radioButton2";
            this.rdoextranjero.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1.primero",
            "2.segundo",
            "3.tercero"});
            this.listBox1.Location = new System.Drawing.Point(192, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(21, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(29, 13);
            this.lbltitulo.TabIndex = 4;
            this.lbltitulo.Text = "titulo";
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(118, 57);
            this.txttexto.Multiline = true;
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(105, 37);
            this.txttexto.TabIndex = 5;
            // 
            // cmbpais
            // 
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Items.AddRange(new object[] {
            "uruguay",
            "argentina",
            "bolivia",
            "chile",
            "brazil"});
            this.cmbpais.Location = new System.Drawing.Point(192, 184);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(121, 21);
            this.cmbpais.TabIndex = 6;
            // 
            // frmPantallaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 236);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gbestudiante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkcheck);
            this.Name = "frmPantallaDos";
            this.Text = "frmPantallaDos";
            this.Load += new System.EventHandler(this.frmPantallaDos_Load);
            this.gbestudiante.ResumeLayout(false);
            this.gbestudiante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox chkcheck;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.GroupBox gbestudiante;
    private System.Windows.Forms.RadioButton rdoargentino;
    private System.Windows.Forms.RadioButton rdoextranjero;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label lbltitulo;
    private System.Windows.Forms.TextBox txttexto;
    private System.Windows.Forms.ComboBox cmbpais;
  }
}