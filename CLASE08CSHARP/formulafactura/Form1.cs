using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONSOLA;


namespace formulafactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //object es mas generico
            Factura factura = new Factura();
            foreach (Cambio nombre in Enum.GetName(typeof(Cambio))
                cmbMoneda.Items.add(nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto(1,"monitor21",1000);
            Producto producto2 = new Producto(2,"teclado",1000);
            Factura factuar1 = new Factura();
            //lista pblica
            //factuar1.producto.Add(producto1);
            //factuar1.producto.Add(producto2);
            
            //factuar1[1] = producto1;
            //
            //lista privada
            factuar1[producto1.Identificador] = producto1;
            factuar1[producto2.Identificador] = producto2;
            MessageBox.Show(factuar1.getTotalFactura().ToString());
            MessageBox.Show(producto1.Identificador.ToString());
        }
    }
}
