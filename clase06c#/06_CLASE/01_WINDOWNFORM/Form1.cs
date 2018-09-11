using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_WINDOWNFORM
{
  public partial class frmFormulario : Form
  {
    public frmFormulario()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MessageBox.Show("estoy en el load");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (
          MessageBox.Show("HOLA MUNDO", "titulo", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        this.btnBoton.Text = "si";
      }
      else if(MessageBox.Show("HOLA MUNDO", "titulo", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
      {
        this.btnBoton.Text = "no";
      }
      else
      {

        this.btnBoton.Text = "cancel";
      }


    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      //MessageBox.Show("estoy en el paint");
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      //MessageBox.Show("estoy en el activate");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("estoy en el formclosing", "guardar", MessageBoxButtons.YesNo) == DialogResult.No)
        e.Cancel = true;//hereda de la clase 
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      MessageBox.Show("estoy en el formclosed");
    }

    private void btnMostrar_Click(object sender, EventArgs e)//creo formulario pantallados y boton mostrar
    {
      frmOwner ownertres = new frmOwner();
      //crearinstancia de ak mostarr sal to a form 2
      frmPantallaDos frmdos = new frmPantallaDos();
      frmPantallaDos frmtre = new frmPantallaDos();
      frmPantallaDos frmcuatro = new frmPantallaDos();
      //00:00:
      frmdos.MdiParent = this;
      frmcuatro.MdiParent = this;

      //frmdos.Show();//Crea un objeto crea un objeto
      //frmdos.ShowDialog(); //espera respuesta; si no cierra//no deja cerrarlo
      this.btnMostrar.Text=frmdos.atributoString;

      //5:00
      //ownertres.Show();
      frmcuatro.Show();
      frmtre.Show();
      //frmdos.Show(ownertres);
      //12:00
      //this.MdiChildren
      //frmcuatro.MdiParent = this;
      //frmdos.Owner.Text="asdasd";
      //frmtre.Parent.Text = "";
      //20:00 ordena formulario
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      frmPantallaDos frmpantalla4 = new frmPantallaDos();
      frmpantalla4.MdiParent = this;
      frmpantalla4.Show();

      
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileVertical);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.LayoutMdi(MdiLayout.TileHorizontal);
    }
  }
}
