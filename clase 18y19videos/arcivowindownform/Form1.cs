using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

/*
 * https://www.youtube.com/watch?v=PgLNwOYxPH0
 * https://www.youtube.com/watch?v=9uVjKTmT1oE
 * https://www.youtube.com/watch?v=DKXVUP52A38&index=20&list=PLM-p96nOrGcY3KBk1k-I9eMUs4HpZAy5U
*/
namespace arcivowindownform
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    string carpeta = Application.StartupPath + @"\Contenedor";
    string archivo = "ArchivoTexto.txt";
    private bool openFileDialogl;
    private bool openFileDialog1;

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      string ubicacion = carpeta + archivo;

      string leer = File.ReadAllText(ubicacion);
      textBox1.Text = leer;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string crear = carpeta + archivo;

      try
      {
        if (File.Exists(crear))
        {
          MessageBox.Show("archivo existe");

        }
        else
        {
          MessageBox.Show("no existe el archivo........ creando");
          Directory.CreateDirectory(carpeta);
          using (File.Create(crear));

          string texto = "hola este texto es el que aparece";
          File.WriteAllText(crear,texto);

        }
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }





    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (openFileDialog2.ShowDialog() == DialogResult.OK)
      { }
      
    }

    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
    {

    }
  }
}
