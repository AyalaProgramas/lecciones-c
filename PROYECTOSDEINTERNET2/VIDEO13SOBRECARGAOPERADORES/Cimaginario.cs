using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIDEO13SOBRECARGAOPERADORES
{
    public class Cimaginario:IComparable
    {
        private double _entero;
        private double _imaginario;

        public Cimaginario(double enteroparametro, double imaginarioparametro)
        {
            this._entero = enteroparametro;
            this._imaginario = imaginarioparametro;
        }



        public double MyPropertyentero
        {
            get { return this._entero; }
            set { this._entero = value; }
        }



        public double MyPropertyimaginario
        {
            get { return this._imaginario; }
            set { this._imaginario = value; }
        }

        public override string ToString()
        {
            if (_imaginario < 0)
            {
                return string.Format("({0}  {1}i)", this._entero, this._imaginario);
            }
            else
            {
                return string.Format("({0}  {1}i)", this._entero, this._imaginario);
            }
        }

        public static Cimaginario operator +(Cimaginario numerouno, Cimaginario numerodos)
        {
            double realentero = 0;
            double realimaginario = 0;

            realentero = numerouno._entero + numerodos._entero;
            realimaginario = numerouno._imaginario + numerodos._imaginario;

            Cimaginario temporal = new Cimaginario(realentero, realimaginario);
            return temporal;
        }

        public static Cimaginario operator -(Cimaginario numerouno, Cimaginario numerodos)
        {
            double realentero = 0;
            double realimaginario = 0;

            realentero = numerouno._entero - numerodos._entero;
            realimaginario = numerouno._imaginario - numerodos._imaginario;


            Cimaginario temporal = new Cimaginario(realentero, realimaginario);

            return temporal;


        }
        public static Cimaginario operator *(Cimaginario numerouno, Cimaginario numerodos)
        {
            double R_E = 0;
            double R_I = 0;

            R_E = (numerouno._entero * numerodos._entero) - (numerouno._imaginario * numerodos._imaginario);
            R_I = (numerouno._entero * numerouno._imaginario) + (numerouno._imaginario * numerodos._entero);

            Cimaginario temporal = new Cimaginario(R_E, R_I);

            return temporal;


        }

        public static Cimaginario operator /(Cimaginario numerouno, Cimaginario numerodos)
        {
            double R_E = 0;
            double R_I = 0;

            R_E = (numerouno._entero * numerodos._entero) + (numerouno._imaginario * numerodos._imaginario) / (numerodos._entero * numerodos._entero) + (numerodos._imaginario * numerodos._imaginario);
            R_I = (numerouno._entero * numerodos._imaginario) + (numerouno._imaginario * numerodos._imaginario) / (numerodos._entero * numerodos._entero) + (numerodos._imaginario * numerodos._imaginario);

            Cimaginario temporal = new Cimaginario(R_E, R_I);
            return temporal;


        }
        //sobrecarga de operaodores unarios
        public static Cimaginario operator ++(Cimaginario i1)
        {
            Cimaginario temporal = new Cimaginario(i1._entero + 1, i1._imaginario + 1);

            return temporal;
        }


        public static Cimaginario operator --(Cimaginario i1)
        {
            Cimaginario temporal = new Cimaginario(i1._entero - 1, i1._imaginario - 1);

            return temporal;
        }

        public override bool Equals(object obj)
        {
            if (obj is Cimaginario)
            {
                Cimaginario temporal = (Cimaginario)obj;
                if (_imaginario == temporal._imaginario && _entero == temporal._entero)
                { return true; }

            }
            return false;
        }

        public static bool operator ==(Cimaginario numerouno, Cimaginario numerodos)
        {
            return numerouno.Equals(numerodos);
        }

        public static bool operator !=(Cimaginario numerouno, Cimaginario numerodos)
        {
            return !(numerouno.Equals(numerodos));
        }

        public double magnitud()
        {
            double m = 0;

            m = Math.Sqrt((this._entero * this._entero) + (this._imaginario * this._imaginario));

            return m;
        }


        //odj recibe datos de magnitud
        public int CompareTo(object obj)//metodo qu eviene por "Icomparable"
        {
            if (obj is Cimaginario)//verifica si el obje es del tipo adecuado para hcer la comparacion
            {
                Cimaginario temporal = (Cimaginario)obj;//castea obje en cimaginario y guarda lo q tn adent

                if (magnitud() > temporal.magnitud())
                    return 1;

                if (magnitud() < temporal.magnitud())
                    return -1;
            }

            return 0;
        }


        public static bool operator <(Cimaginario numerouno, Cimaginario numerodos)
        {
            if (numerouno.CompareTo(numerodos) < 0)//numerouno lo usamos de base de comparacion y pasamos numerodos como "obj"
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator >(Cimaginario numerouno, Cimaginario numerodos)
        {
            if (numerouno.CompareTo(numerodos) > 0)//numerouno lo usamos de base de comparacion y pasamos numerodos como "obj"
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static implicit operator int(Cimaginario numerouno)
        {
            return (int)numerouno._entero;
        }

        public static implicit operator string(Cimaginario numerouno)
        {
            return numerouno._entero.ToString();
        }
    }
}
