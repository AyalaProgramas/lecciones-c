using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    public class Lavadero
    {
        public enum EVehiculos{Auto,Camion,Moto}

        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;


        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
            
        }

        public Lavadero(string razonSoc)
            : this()
        {
            this._razonSocial = razonSoc;
        }

        static Lavadero()// La 1ra vea q instancie un obj de la clase
        {
            Random aleatorio = new Random();
            Lavadero._precioAuto = (float)aleatorio.Next(150, 565);
            Lavadero._precioCamion = (float) aleatorio.Next(150, 565);
            Lavadero._precioMoto = (float)aleatorio.Next(150, 565);
        }

        public List<Vehiculo> Vehiculos 
        {
            get
            {
                return this._vehiculos;
            }         
        }
        /// <summary>
        /// Propiedad de solo lectura que retorna una cadena con todos
        /// los datos del Lavadero y sus autos
        /// </summary>
        public string LavaderoProp
        {
            get
            {
                StringBuilder superCadena = new StringBuilder();
                superCadena.AppendLine("Razon Social: " + this._razonSocial);
                superCadena.AppendLine("Valores de Lavadero:");
                superCadena.AppendLine("Auto: " + Lavadero._precioAuto);
                superCadena.AppendLine("Camion: " + Lavadero._precioCamion);
                superCadena.AppendLine("Moto: " + Lavadero._precioMoto);

                // Recorro y voy leyendo y agregando los vehiculos que se encuentran
                foreach (Vehiculo v in this.Vehiculos)
                {
                    v.ToString();// Ya sabe q hacer xq esta sobrecargado                   
                }
                return superCadena.ToString();
            }
        }

        public double MostrarTotalFacturado()
        {
            return MostrarTotalFacturado(EVehiculos.Moto) + MostrarTotalFacturado(EVehiculos.Auto) + MostrarTotalFacturado(EVehiculos.Camion); 
        }

            private double MostrarTotalFacturado(EVehiculos tipo)
            {
                double ganancia = 0;
                foreach (Vehiculo v in this.Vehiculos)
                {
                    switch(tipo)
                    {
                        case EVehiculos.Auto:
                            if(v is  Auto)
                            {
                                ganancia += Lavadero._precioAuto;
                            }
                            break;
                        case EVehiculos.Camion:
                            if (v is Camion)
                            {
                                ganancia += Lavadero._precioCamion;
                            }
                            break;
                        case EVehiculos.Moto:
                            if (v is Moto)
                            {
                                ganancia += Lavadero._precioMoto;
                            }
                            break;
                    }
                }

                return ganancia;
            }


        public static bool operator ==(Lavadero lavuno,Vehiculo vehiculouno)
        {
            bool retorno = false;
            foreach ( Vehiculo i in lavuno._vehiculos )
            {
                if (i==vehiculouno)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero lavuno, Vehiculo vehiculouno)
        {


            return !(lavuno == vehiculouno);
        }




        public static int ordenarvehiculoporpatente(Vehiculo vehiculouno,Vehiculo vehiculodos)
        {
            int retorno = -1;

            if (vehiculouno.Patente==vehiculodos.Patente)
            {
                retorno = 0;
            }
            if (String.Compare(vehiculouno.Patente,vehiculodos.Patente)>0)
            {
                retorno = 1;
            }
            return retorno;
        }

        public int ordenarvehiculopormarca(Vehiculo vehiculouno, Vehiculo vehiculodos)
        {
            int retorno = -1;
            if (vehiculouno.Marca == vehiculouno.Marca)
                retorno = 0;
            if (String.Compare(vehiculouno.Marca.ToString(), vehiculouno.Marca.ToString()) > 0)
                retorno = 1;
            return retorno;
        }
    }
}
