using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYLIST
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            //podemos adicionar con rango
            palabras.AddRange(new string[]{"hola","como","estan?"});

            Console.WriteLine("cantidad de elementos en el arraylist es {0}",palabras.Count);

            for ( n = 0; n < palabras.Count; n++)
            {
                Console.Write("{0}\n",palabras[n]);
            }

            Console.WriteLine();
            Console.WriteLine("-------");

            palabras.Add("bien y tu?");

            foreach (string reciboloqhayenarrlis in palabras)
            {
                Console.Write("{0} ", reciboloqhayenarrlis);
            }

            ArrayList valores = new ArrayList();

            valores.Add(5);
            valores.Add(6);
            valores.Add(7);
            valores.Add(4);

            for (int i = 0; i <valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);


            }
            Console.WriteLine("-----");

            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(13));

            valores.Insert(2,55);
            valores.RemoveAt(2);
            for (int i = 0; i < valores.Count; i++)
            {
                r = (int)valores[i];
                Console.WriteLine(r);


            }
            Console.WriteLine("-------");

        }
    }
}
