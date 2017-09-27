using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Auto:Vehiculo
    {
        protected int _cantidadAsientos;


        /// <summary>
        /// Constructor parametrizado que inicializa los atributos heredados
        /// de la clase padre y al atributo ùnico de clase
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="marca"></param>
        /// <param name="cantRuedas"></param>
        /// <param name="cantAsient"></param>
        public Auto(string patente, EMarcas marca, byte cantRuedas, int cantAsient)
            : base(patente, marca, cantRuedas)
        {
            this._cantidadAsientos = cantAsient;
        }
        /// <summary>
        /// Sobrecarga de constructor
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="marca"></param>
        /// <param name="cantAsient"></param>
        public Auto(string patente, EMarcas marca, int cantAsient)
            :this(patente,marca,4,cantAsient)// Harcodearlo si no lo tengo
        {          
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.ToString());
            cadena.AppendLine("Cantidad Asientos: " + this._cantidadAsientos);
            return cadena.ToString();
        }
    }
}
