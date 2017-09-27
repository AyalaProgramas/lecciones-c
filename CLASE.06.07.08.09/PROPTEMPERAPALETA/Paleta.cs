using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPTEMPERAPALETA
{
    public class Paleta
    {
        private List<Tempera> _lista;
        private int _cantMaximaColores;

        private Paleta(int num)
        {
            this._lista = new List<Tempera>();
            this._cantMaximaColores = num;

        }

        private Paleta()
            : this(5)
        {
 
        }

        public static implicit operator Paleta(int c)
        {
            return new Paleta(c);
        }

        private string mostrar()
        {
            string retorno = "";
            foreach (Tempera tempera in _lista)
            {
                retorno += Tempera.Mostar(tempera);
            }
            return retorno;
        }

        public static explicit operator string(Paleta paletaparametro)
        {
            return paletaparametro.mostrar();
        }

        public static bool operator==(Paleta paletaparametro,Tempera temperaparametro)
        {
            bool retorno = false;
            foreach (Tempera tempera in paletaparametro._lista)
            {
                if (tempera == temperaparametro)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator!=(Paleta paletaparametro,Tempera temperaparametro)
        {
            return !(paletaparametro==temperaparametro);
        }

        public static Paleta operator + (Paleta paletaparametro, Tempera temperaparametro)
        {
            if (paletaparametro != temperaparametro && paletaparametro._cantMaximaColores > paletaparametro._lista.Count)
            {
                paletaparametro._lista.Add(temperaparametro);
            }
            else
            {
                int cont = 0;
                foreach (Tempera tempera in paletaparametro._lista)
                {
                    if (tempera==temperaparametro)
                    {
                        paletaparametro._lista[cont] += temperaparametro;
                        break;
                    }
                    cont++;
                }
               
            }

            return paletaparametro;
        }

        public static Paleta operator - (Paleta paletaparametro,Tempera temperaparametro)
        {
            if (paletaparametro == temperaparametro)
            {
                int contador = paletaparametro._lista.Count;
                for (int i = 0; i<contador;i++ )
                {
                    if(paletaparametro._lista[i]==temperaparametro)
                    {
                        paletaparametro._lista.RemoveAt(i);
                    }
                }
            }
                return paletaparametro;
        }

        public static Paleta operator +(Paleta paletauno,Paleta paletados)
        {
            Paleta paletanueva = new Paleta(paletauno._cantMaximaColores+paletados._cantMaximaColores);

            for (int index = 0; index <paletauno._cantMaximaColores; index++)
            {
                paletanueva+=paletauno._lista[index];
            }
            for (int index = 0; index < paletados._cantMaximaColores; index++)
            {
                paletanueva+=paletados._lista[index];
            }

            return paletanueva;
        }

        public List<Tempera> getTempera()//(7)
        {
            return this._lista;
        }

        public Tempera this[int indice]
        {
            get
            {
                if (indice >= this._lista.Count || indice < 0)
                    return null;
                else
                    return this._lista[indice];
            }
            set
            {
                if (indice >= 0 && indice < this._lista.Count)
                    this._lista[indice] = value;
                else if (indice == this._lista.Count)// verificar que no sean iguales
                {
                    Paleta aux = this + value;
                    this._lista = aux._lista;
                }

            }
        } 
    }
}
