using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIAS
{
    public class Persona
    {
        private string _apellido;
        private string _nombre;
        private int _dni;

        private string myVar;

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }


        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int Dni
        {
            get { return this._dni; }
            set { this._dni = value; }
        }


        public Persona(string apellido, string nombre, int dni)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._nombre = nombre;
        }

        public static int ordenarpersonapordni(Persona a,Persona b)
        {
            int retorno = 0;

            if (a._dni > b._dni)
            {
                retorno = 1;
            }
            if (a._dni < b._dni)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int ordenarpersonaporapellido(Persona a, Persona b)
        {
            int retorno = 0;

            if (String.Compare(a._apellido,b._apellido)<0)
            {
                retorno = 1;
            }
            if (String.Compare(a._apellido, b._apellido) > 0)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static int ordenarpersonapornombre(Persona a, Persona b)
        {
            int retorno = 0;

            if (String.Compare(a._nombre, b._nombre) < 0)
            {
                retorno = 1;
            }
            if (String.Compare(a._nombre, b._nombre) > 0)
            {
                retorno = -1;
            }

            return retorno;
        }

        public static string mostrarlista(List<Persona> lista)
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.AppendLine("*********************************************************************");

            foreach (Persona i in lista)
            {
                sb.AppendLine(i);
            }

            sb.AppendLine("*********************************************************************");

            return sb.ToString();



        }

        public static implicit operator string(Persona p)
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.Append("apellido: ");
            sb.Append(p._apellido);
            sb.Append("  *  ");


            sb.Append("nombre: ");
            sb.Append(p._nombre);
            sb.Append("  *  ");


            sb.Append("dni: ");
            sb.Append(p._dni);
            sb.Append("  *  ");

            return sb.ToString();
        }


    }
}
