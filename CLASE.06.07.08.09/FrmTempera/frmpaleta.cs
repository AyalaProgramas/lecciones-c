using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROPTEMPERAPALETA;


namespace FrmTempera
{
    public partial class frmpaleta : Form
    {
        private Paleta _paleta;
        public frmpaleta()//(1)
        {
            InitializeComponent();
            this._paleta=(5);
        }

        //botonmas
        private void button1_Click(object sender, EventArgs e)//agrego con mas y entro ak//(2)
        {
            frmTempera frm = new frmTempera();
            frm.ShowDialog();//(6)

            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this._paleta += frm.gettempera();
                lstColores.Items.Clear();
                foreach (Tempera t in this._paleta.getTempera())
                {
                    lstColores.Items.Add(Tempera.Mostar(t));
                }
            }


        }

        //boton menos
        private void button2_Click(object sender, EventArgs e)
        {
            int indice = lstColores.SelectedIndex;
            frmTempera frmtemperauno = new frmTempera(this._paleta.getTempera()[indice]);

            if (frmtemperauno.ShowDialog() == System.Windows.Forms.DialogResult.OK)//??????????
            {
                lstColores.Items.Clear();
                this._paleta.getTempera().RemoveAt(indice);
            }
            this.lstColores.Items.Clear();
            listartemperas();

        }





        public void listartemperas()
        {
            foreach (Tempera temp in this._paleta.getTempera())
            {
                this.lstColores.Items.Add(Tempera.Mostar(temp));
            }
        }
    }
}
