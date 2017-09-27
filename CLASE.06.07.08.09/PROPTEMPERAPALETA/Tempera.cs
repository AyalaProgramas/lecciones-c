using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPTEMPERAPALETA
{
    public class Tempera
    {

        private int _cantidad;
        private ConsoleColor _color;
        private string _marca;


        public Tempera(ConsoleColor colorparametro,string marcaparametro, int cantidadparametro)///(a2)
        {
            this._color = colorparametro;
            this._marca = marcaparametro;
            this._cantidad = cantidadparametro;
        }

        private string Mostrar()
        {
            string retorno;
            return retorno = ("Marca: " + this._marca + " /color: " + this._color + " /cantidad: " + this._cantidad);
        }

        public static string Mostar(Tempera tempera)
        {
            return tempera.Mostrar();
        }


        public static bool operator ==(Tempera temperauno,Tempera temperados)
        {
            return temperauno._color == temperados._color && temperauno._marca == temperados._marca;
        }

        public static bool operator !=(Tempera temperauno, Tempera temperados)
        {
            return !(temperauno == temperados);
        }



        public static Tempera operator+(Tempera temperaparametro,double numeroparametro)
        {
            int cantidad = temperaparametro._cantidad + (int)numeroparametro;
            if (numeroparametro > 0 && cantidad <= 100)
                temperaparametro._cantidad += (int)numeroparametro;
            return temperaparametro;


        }

        public static implicit operator int(Tempera temperaoperator)
        {
            return (int)temperaoperator._cantidad;
        }

        public string getMarca()
        {
            return this._marca;
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }

        public string getCantidad()
        {
            return Convert.ToString(this._cantidad);
        }















        public static int ordenarpersonapordni(Tempera a, Tempera b)
        {
            int retorno = 0;

            if (a._cantidad > b._cantidad)
            {
                retorno = 1;
            }
            if (a._cantidad < b._cantidad)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int ordenarpersonapormarca(Tempera a, Tempera b)
        {
            int retorno = 0;

            if (String.Compare(a._marca, b._marca) < 0)
            {
                retorno = 1;
            }
            if (String.Compare(a._marca, b._marca) > 0)
            {
                retorno = -1;
            }

            return retorno;
        }

        //public static int ordenarpersonapornombre(ConsoleColor a, ConsoleColor b)
        //{
        //    int retorno = 0;
            
        //    if (String.Compare(a._color, b._color) < 0)
        //    {
        //        retorno = 1;
        //    }
        //    if (String.Compare(a._color, b._color) > 0)
        //    {
        //        retorno = -1;
        //    }

        //    return retorno;
        //}

        public static string mostrarlista(List<Tempera> lista)
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.AppendLine("*********************************************************************");

            foreach (Tempera i in lista)
            {
                sb.AppendLine(i);
            }

            sb.AppendLine("*********************************************************************");

            return sb.ToString();



        }

        public static implicit operator string(Tempera p)
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.Append("color: ");
            sb.Append(p._color);
            sb.Append("  *  ");


            sb.Append("marca: ");
            sb.Append(p._marca);
            sb.Append("  *  ");


            sb.Append("cantidad: ");
            sb.Append(p._cantidad);
            sb.Append("  *  ");

            return sb.ToString();
        }

    }
}
