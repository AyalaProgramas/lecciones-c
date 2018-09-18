using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class Producto
    {

        private int identificador;
        private String nombre;
        private double precio;
        private double iva;
        private double total;
        private int cantidad;
        //referenciar la dll
        //los enumerados remplasan alos enteros string flotante
       //sobrecarga de operadores peso a dolar y aeuro

        public int Identificador
        {
            get { return this.identificador; }
            set { this.identificador = value; }
        }
        

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public double Precio { set {this.precio=value; } }

        public double Total
        {
            get {

                
                    return (this.precio+this.total)*this.Cantidad;

            }

                    
        }

       


        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto(int identificador, String nombre, double precio)   
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.precio = precio;

        }

        public double gettotal()
        {
            this.iva = this.precio * .21;
            return this.precio*1.21;
        }


    }














    public class Factura
    {
        
         int numero;
         DateTime facha;
         Cambio moneda;
        // public List<Producto> producto;//agregar idexador
        List<Producto> producto;
        int tipo;//para hacerlo del tipo de factura usamos con enumerados

        public enum Cambio
        {
            dolar,
            euro,
            peso
        }
        public enum enumerafactura
        {
            A,
            B,
            C,
            D
            
        }

        //indexadores
        public Producto this[int i]
        {
            
            get {
                Producto salida = null;
                foreach (Producto item in this.producto)
                {
                    if (item.Identificador == i)
                        return item;
                }
                return salida;


            }
            set {
                bool encontro = false; 
                    if(this.producto.Count<=i)
                    {
                        foreach (Producto item in this.producto)
                        {
                            if (item.Identificador == value.Identificador)
                            {
                                item.Cantidad+=value.Cantidad;
                            encontro = true;

                            }
                        
                         
                        }
                        if (!encontro)
                        {
                            this.producto.Add(value);
                        }

                }
                    
            }
        }

        public int Numero { get { return this.numero; } set { this.numero = value; } }

        public DateTime Facha { get { return this.facha; }  set { this.facha = value; } }

        public int Tipo { get => tipo; set => tipo = value; }
        public Cambio Moneda { get => moneda; set => moneda = value; }

        public Factura()
        {
            this.producto = new List<Producto>();
        }
              
        public double getTotalFactura()
        {
            double total=0;
            foreach (Producto item in this.producto)
            {
                total += item.gettotal();
            }

            return total;
        }

        public double Total
        {
            get
            {

                double total = 0;

                foreach (Producto item in this.producto)
                {

                    total += item.Total;
                }

                double cambiototal = 0;
                Cambio camb = Cambio.peso;
                switch(camb)
                {
                    case Cambio.dolar:
                        cambiototal = (Peso)new Dolar(total);
                        break;
                    case Cambio.euro:
                        cambiototal = (Peso)new Euro(total);
                        break;
                    case Cambio.peso:
                        cambiototal = (Peso)total;
                        break;


                }
                total = cambiototal;
                return total;

            }


        }

    }
}
