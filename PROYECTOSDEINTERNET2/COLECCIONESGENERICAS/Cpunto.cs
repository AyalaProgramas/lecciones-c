using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLECCIONESGENERICAS
{
    public class CPunto//creamos la clase para usar los metodos de list<>
    {
        private int _X;
        private int _y;

        public CPunto(int px, int py)
        {
            this._X = px;
            this._y = py;
        }

        public override string ToString()// el override nos imprime los valores q tiene el objeto
        {
            return string.Format("x={0},y={1}", _X, _y);
        }



    }
}
