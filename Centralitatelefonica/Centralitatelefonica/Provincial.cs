using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralitatelefonica
{
    public class Provincial:Llamada
    {
        protected Efranja _franjahoraria;


       public float  Costodellamada 
       { 
           get
           {
               return this.Costodellamada;
           }
       } 

        public float CalcularCosto()
        {
            float valorllamada = 0;
            switch(this._franjahoraria)
            {
                case Efranja.Franja_1:
                    valorllamada = 0.99f;
                    break;
                case Efranja.Franja_2:
                    valorllamada = 1.25f;
                    break;
                case Efranja.Franja_3:
                    valorllamada = 0.66f;
                    break;
                default:
                    valorllamada = 0;
                    break;
            }


            return (base.Duracion * valorllamada);
            
        }

        //public void Mostrar()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine(base._duracion + base._nroDestino + base._nroOrigen + Costodellamada);
        //    Console.WriteLine(sb);
        //}

       

        public Provincial(string origen, Efranja mifranja, float duracion, string destino)//se esta llamando asi mismo
            :base(origen,destino,duracion)
        {
           this._franjahoraria = mifranja;
        }

        public Provincial(Efranja mifranja, Llamada unallamada)
            : this(unallamada.NroOrigen,mifranja,unallamada.Duracion,unallamada.NroDestino)
        {
            

        }

        protected virtual string Mostrar()// Agrego el prefijo new para que no marque posible error
        {
            StringBuilder cadena = new StringBuilder();

            cadena.Append(base.Mostrar());
            cadena.AppendLine("Franja Horaria: " + (Efranja)this._franjahoraria);// Ver si esto está bien OJO ***************************
            cadena.AppendFormat("Costo Llamada: $ {0}", this.Costodellamada);

            return cadena.ToString();
        }

        public override string ToString()
        {

            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
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
