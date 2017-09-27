using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralitatelefonica
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        

        public float GanaciasporLocal
        {
            get { return this.CalcularGanancias(Etipollamada.Local) ; }
            
        }
        
         public float GananciasPorProvincias
        {
            get { return this.CalcularGanancias(Etipollamada.Provincial) ; }
            
        }

         public float GanaciasTotal
        {
            get { return this.CalcularGanancias(Etipollamada.Todas) ; }
            
        }

         public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
            
        }

        private float CalcularGanancias(Etipollamada tipo)
        {
            // Variable para ir acumulando los costos de las ganancias
            float gananciaLocal = 0;
            float gananciaProv = 0;
            float gananciaTotal = 0;

            // Recorro la lista buscando coincidencia de tipo de llamada
            foreach (Llamada i in this._listaDeLlamadas)
            {
                // Ante la igualdad de tipo incremento el acumulador 
                if (i is Local)
                {
                    gananciaLocal += ((Local)i).CostoLLamada;
                    gananciaTotal += ((Local)i).CostoLLamada;
                }
                if (i is Provincial)
                {
                    gananciaProv += ((Provincial)i).Costodellamada;
                    gananciaTotal += ((Provincial)i).Costodellamada;
                }
            }
            if (tipo == Etipollamada.Local)
                return gananciaLocal;
            else if (tipo == Etipollamada.Provincial)
                return gananciaProv;
            else
                return gananciaTotal;
        }


        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()

        {
            this._razonSocial = nombreEmpresa;
        }

        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("Razon Social: " + this._razonSocial);
            cadena.AppendLine("Ganancia Total: " + this.GanaciasTotal);
            cadena.AppendLine("Ganancia Llamadas Locales: " + this.GanaciasporLocal);
            cadena.AppendLine("Ganancia Llamadas Provinciales: " + this.GananciasPorProvincias);
            cadena.AppendLine("********************************************");
            cadena.AppendLine("Detalle de Llamadas Realizadas: ");

            foreach (Llamada i in this._listaDeLlamadas)
            {
                //if (i is Local)
                //    cadena.AppendLine(((Local)i).Mostrar());
                //else
                //    cadena.AppendLine(((Provincial)i).Mostrar());
                i.Mostrar();
            }
            return cadena.ToString();

        }


        public void OrdenarLLamadas()
        { 
            

        }
        //recibe la llamada 
        private void agregarllamada(Llamada llamadauno)
        {
            this._listaDeLlamadas.Add(llamadauno);
        }
        //devuelve true cuando llamada esta dentro de centalita

        public static bool operator ==(Centralita parametrouno, Llamada parametrodos)
        {
            bool retornar=false;

            foreach (Llamada i in parametrouno._listaDeLlamadas)
	        {
		        if( i is Llamada)
                {
                    return true;
                    
                }

	        }

            return retornar;
        }


        public static bool operator !=(Centralita parametrouno, Llamada parametrodos)
        {
            return !(parametrouno == parametrodos);


        }

        //permite agregar una llamada en centr
 
        public static Centralita operator +(Centralita central,Llamada llamada)
        {
            if (central == llamada)
            {
                central._listaDeLlamadas.Add(llamada);
            }

            return central;
        }

    }
}
