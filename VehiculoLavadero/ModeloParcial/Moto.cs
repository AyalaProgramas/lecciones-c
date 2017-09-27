using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    
    public class Moto:Vehiculo
    {
        protected float _cilindrada;

        /// <summary>
        /// Constructor parametrizado que inicializa los atributos heredados
        /// de la clase padre y al atributo ùnico de clase
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="marca"></param>
        /// <param name="cantRuedas"></param>
        /// <param name="cilindradas"></param>
        public Moto(string patente, EMarcas marca,float cilindradas, byte cantRuedas)
            : this(patente, marca, cantRuedas)
        {
            this._cilindrada = cilindradas;
        }

        public Moto(string patente,EMarcas marca,byte cantRuedas):base(patente,marca,cantRuedas)
        {
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.ToString());
            cadena.AppendLine("Cilindradas: " + this._cilindrada);
            return cadena.ToString();
        }
    }
}
