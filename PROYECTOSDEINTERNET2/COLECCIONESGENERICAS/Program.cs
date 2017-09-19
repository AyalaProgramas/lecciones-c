using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLECCIONESGENERICAS
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> valores = new List<int>();
            int n = 0;
            int k = 0;

            valores.Add(4);
            valores.Add(5);
            valores.Add(7);
            valores.Add(2);
            valores.Add(3);
            valores.Add(1);
            valores.Add(8);
            // recorremos con ciclo for
            for (int i = 0; i < valores.Count; i++)
            {
                //no hay nesesidad de type cast
                n = valores[i];
                Console.WriteLine(n);
            }

            Console.WriteLine("----------");

            //vemos si contiene a determinar elemento
            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(11));

            Console.WriteLine("----------");

            // obtenemos indice de un elemento
            Console.WriteLine(valores.IndexOf(1));
            Console.WriteLine(valores.IndexOf(14));
            Console.WriteLine("----------");

            //insertemos elementos en un indice

            valores.Insert(3, 55);

            foreach (int recibelementoint in valores)
            {
                Console.WriteLine(recibelementoint);
            }

            Console.WriteLine("----------");

            ///eliminamos elemento en un indice


            valores.RemoveAt(1);

            foreach (int recibeelementos in valores)
            {
                Console.WriteLine(recibeelementos);
            }

            Console.WriteLine("----------");

            //eliminamos la primera que encuentre ocurrencia de un valor
            valores.Remove(1);

            foreach (int reciveelementoint in valores)
            {
                Console.WriteLine(reciveelementoint);
            }

            Console.WriteLine("...........");
            //la lista lo pone en sentido contarrio
            valores.Reverse();

            foreach (int recibelementos in valores)//reciveelemnetos recibe los elementos de la lista valores
            {
                Console.WriteLine(recibelementos);//imprime lo de la lista valores uno por uno
            }

            Console.WriteLine("...........");

            //mandamos a ordenar la lista 
            valores.Sort();//sim queremos hacer un sort con una clase hecha
            //esta clase tiene q llevar a cabo la implementacion de "IComparable"
            //sim no lo implementamos SortedDictionary no sabe con sort comparar yield ordenar

            foreach (int recibeelementos in valores)
            {
                Console.WriteLine(valores);
            }
            foreach (int recibeelementos in valores)
            {
                Console.WriteLine(recibeelementos);
            }
            Console.WriteLine("...........");

            //creamos una lista para nuestra clase

            List<CPunto> listapunto = new List<CPunto>();//esto crea una de list q trabaja con cpunto


            listapunto.Add(new CPunto(4, 5));
            listapunto.Add(new CPunto(1, 1));
            listapunto.Add(new CPunto(3, 7));
            listapunto.Add(new CPunto(2, 8));

            foreach (CPunto punto in listapunto)
            {
                Console.WriteLine(punto);
            }

            //no funsiona por que no hemos implementdo iComparable
            //listapunto.Sort();
            Console.WriteLine("...........");










            //OTRA FORMA DE ADICIONAR PUNTOS
            //ADICION EXPLICITA, NO CON ADD


            List<CPunto> puntos = new List<CPunto>
            {
                new CPunto(3, 4),//va con coma al final
                new CPunto(4, 8),
                new CPunto(7, 9),
            };


            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("...........");

            //adicionamos un punto

            puntos.Add(new CPunto(44, 55));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("...........");

            //insertamos un punto
            puntos.Insert(2, new CPunto(22, 65));

            foreach (CPunto p in puntos)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("...........");

            //a veces nesecitamos convertir la lista que tenemos a un arreglo
            //pasa con los tipos double, float y los tipos q creamos

            CPunto[] arreglopuntos = puntos.ToArray();

            for (int i = 0; i < arreglopuntos.Length; i++)
            {
                Console.WriteLine(arreglopuntos[i]);
            }

            Console.WriteLine("...........");



        }
    }
}
