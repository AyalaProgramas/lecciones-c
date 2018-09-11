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
  //a
  public partial class frmPantallaDos : Form//esto es una clase
  {
    public string atributoString = "atributo clase frmdos";
    public frmPantallaDos()
    {
      InitializeComponent();
    }

    private void frmPantallaDos_Load(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;

      this.cmbpais.SelectedIndex = 3;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
     
        
        
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //000700
      //002400
      MessageBox.Show(this.rdoargentino.Checked ? "argentino" : "extranjero"/*this.chkcheck.Checked.ToString()*/);

      //002900
      foreach (Control radio in gbestudiante.Controls)
      {
        if(radio is RadioButton && ((RadioButton)radio).Checked)
        {
          MessageBox.Show(radio.Text);
        }
      }
      //0003300 listbox
      string salida = "";
      foreach(object item in this.listBox1.SelectedItems)
      {
        salida += item.ToString();
      }

      MessageBox.Show(salida);
      //MessageBox.Show(this.listBox1.SelectedItems();
      //004300 no selecciona nada label
      //004720 texbox
      //005000 combobox
    }
  }
}
