using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDOWNFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludo_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "hola a todos";
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "despedida";
        }


    }
}
