using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Vehiculo
    {
        // Recordar que es public!!
        public enum EMarcas { Honda, Ford, Zanella, Scania, Iveco, Fiat }

        protected string _patente;
        protected byte _cantidadRuedas;
        protected EMarcas _marca;

        /// <summary>
        /// Propiedad de solo lectura
        /// </summary>
        public string Patente {
            get
            {
                return this._patente;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura
        /// </summary>
        public EMarcas Marca {
            get
            {
                return this._marca;
            }
        }


        public Vehiculo(string patente, EMarcas marca, byte cantRuedas)
        {
            this._patente = patente;
            this._marca = marca;
            this._cantidadRuedas = cantRuedas;
        }

        /// <summary>
        /// Mètodo que retorna una cadena con los valores de los atributos
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("Patente: " + this._patente);
            cadena.AppendLine("Marca: " + this._cantidadRuedas);
            cadena.AppendLine("Cantidad de ruedas: " + this._cantidadRuedas);
            return cadena.ToString();
        }

        /// <summary>
        /// Mètodo que retorna una cadena con los atributos.Reutiliza còdigo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecarga de operador de igualdad.Compara que coincidan en patente
        /// y marca
        /// </summary>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <returns> True en caso de igualdad False en caso contrario</returns>
        public static bool operator ==(Vehiculo uno, Vehiculo dos)
        {
            bool retorno = false;
            if ((uno.Patente == dos.Patente) && (uno.Marca == dos.Marca))
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uno"></param>
        /// <param name="dos"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo uno, Vehiculo dos)
        {
            return (!(uno == dos));
        
        }

    }
}
