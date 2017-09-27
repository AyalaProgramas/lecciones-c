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
    public partial class frmTempera : Form
    {
        private Tempera _tempera;

        public Tempera gettempera()//(5)
        {
            return this._tempera;
        }


        public frmTempera()//(3)constructor
        {
            InitializeComponent();
            foreach (ConsoleColor i in Enum.GetValues(typeof(ConsoleColor)))//se van agregando los colores de la clase consolecolor ala lista cmbcolores q son 16
            {
                this.cmbcolores.Items.Add(i);//agrego en la lista dinamica
            }
            this.cmbcolores.SelectedItem = ConsoleColor.Black;
            this.cmbcolores.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public frmTempera(Tempera tempera):this()
        {
            this.txtcantidad.Text = tempera.getCantidad();
            this.txtmarca.Text = tempera.getMarca();
            this.cmbcolores.SelectedItem = tempera.getColor();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)//(4) doy aceptar en grafico y entro ak
        {
            string _marca = txtmarca.Text;//captura loq escribi en texbox
            ConsoleColor _color = (ConsoleColor)cmbcolores.SelectedItem;
            int _cantidad = int.Parse(txtcantidad.Text);//captura lo q escribi en textbox

            Tempera nuevatempera = new Tempera(_color, _marca, _cantidad);//inicialiso el onjeto q cree con los datos q le pase al etxtbox///(a1)
            this._tempera = nuevatempera;//el objeto _tempera esta inicialsado con el objeto nuevatempera(q son los datos q elegi en el textbox) 
            this.DialogResult = System.Windows.Forms.DialogResult.OK;//????
        }//(5)

        private void btncancelar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
