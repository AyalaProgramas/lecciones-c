using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralitatelefonica
{
    public class Local:Llamada
    {
        protected float _costo;

        public Local(string origen, string destino, float duracion, float costo)
            :base(origen,destino,duracion)
        { 
               this._costo=costo;
        }

        public Local(Llamada unallamada,float costo)
            //:this(unallamada.NroOrigen,unallamada.NroDestino,unallamada.Duracion)
            :this(unallamada.NroOrigen,unallamada.NroDestino,unallamada.Duracion,costo)
        {
           
        }

        public float CostoLLamada
        {
            get { return this._costo; }
            
        }




        private float calcularCosto()
        {
            float auxiliarcosto;

            auxiliarcosto = this._costo * this._duracion;

            return auxiliarcosto; 

        }

        //public void Mostrar() 
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine(base._duracion + base._nroDestino + base._nroOrigen + CostoLLamada);
        //    Console.WriteLine(sb);
        //}

        protected virtual string Mostrar()// Le agrego el prefijo new para que no indique posible error
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append(base.Mostrar());
            cadena.AppendFormat("Costo: {0}", this.CostoLLamada);// Verificar que el formato asignado esté bien

            return cadena.ToString();
        }


        public override string ToString()
        {



            return this.Mostrar();
        }



        //retorna true si el object q recibe es la misma clase de donde esta
        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
