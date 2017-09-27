using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Camion:Vehiculo
    {
        protected float _tara;


        /// <summary>
        /// Constructor parametrizado que inicializa los atributos heredados
        /// de la clase padre y al atributo ùnico de clase
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="marca"></param>
        /// <param name="cantRuedas"></param>
        /// <param name="laTara"></param>
        public Camion(string patente, EMarcas marca, byte cantRuedas, float laTara)
            : base(patente, marca, cantRuedas)
        {
            this._tara = laTara;
        }

        public Camion(Vehiculo v, float laTara)
            : this(v.Patente, v.Marca, 8, laTara)
        {
            // Recordar no perder parametros            
        }
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.ToString());
            cadena.AppendLine("Tara: " + this._tara);
            return cadena.ToString();
        }
    }
}
