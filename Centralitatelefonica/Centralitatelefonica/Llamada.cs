using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralitatelefonica
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

       

        public float Duracion
        {
            get { return this._duracion; }
            
        }
        
        public string NroDestino
        {
            get { return this._nroDestino; }
            
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
           
        }

        
        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }


        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("---------------------------------");
            cadena.AppendLine("Nro Origen: " + this._nroOrigen);
            cadena.AppendLine("Nro Destino: " + this._nroDestino);
            cadena.AppendLine("Duracion: " + this._duracion);

            return cadena.ToString();
        }

        public int ordenarporduracion(Llamada uno, Llamada dos)
        {
            int retorno = 0;

            if (uno._duracion > dos._duracion)
            {
                retorno = 1;
            }
            if (uno._duracion > dos._duracion)
            {
                retorno = -1;
            }

            return retorno;
        }

        //igualamoas si son de la misma clase
        public static bool operator ==(Llamada numerouno,Llamada numerodos)
        {
            return (numerouno.NroDestino == numerodos.NroDestino) && (numerouno.NroOrigen == numerodos.NroOrigen) && (numerouno.Equals(numerodos));
        }

        public static bool operator !=(Llamada numerouno, Llamada numerodos)
        {
            return !(numerouno == numerodos);
        }

        public static Llamada operator +(Llamada llamadaparametro,Local localparametro)
        {
            llamadaparametro.
        }
        

        
    }
}
