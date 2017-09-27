namespace FrmTempera
{
    partial class frmOrdenar
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cARGARPERSONAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDENARTEMPERAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARGARPERSONAToolStripMenuItem,
            this.oRDENARTEMPERAToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(284, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cARGARPERSONAToolStripMenuItem
            // 
            this.cARGARPERSONAToolStripMenuItem.Name = "cARGARPERSONAToolStripMenuItem";
            this.cARGARPERSONAToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.cARGARPERSONAToolStripMenuItem.Text = "CARGAR TEMPERA";
            // 
            // oRDENARTEMPERAToolStripMenuItem
            // 
            this.oRDENARTEMPERAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.oRDENARTEMPERAToolStripMenuItem.Name = "oRDENARTEMPERAToolStripMenuItem";
            this.oRDENARTEMPERAToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.oRDENARTEMPERAToolStripMenuItem.Text = "ORDENAR TEMPERA";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "por color",
            "por cantidad",
            "por marca",
            "sin ordenar"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // frmOrdenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmOrdenar";
            this.Text = "frmOrdenar";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cARGARPERSONAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDENARTEMPERAToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;

    }
}