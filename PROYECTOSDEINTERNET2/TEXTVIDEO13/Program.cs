using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIDEO13SOBRECARGAOPERADORES;

namespace TEXTVIDEO13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cimaginario im1 = new Cimaginario(4, 4);
            Cimaginario im2 = new Cimaginario(32, 2);
            Cimaginario resultado;

            resultado = im1 + im2;

            Console.WriteLine("{0}+{1}={2}", im1, im2, resultado);

            resultado = im1 - im2;

            Console.WriteLine("{0}-{1}={2}", im1, im2, resultado);
            resultado = im1 * im2;
            Console.WriteLine("{0}*{1}={2}", im1, im2, resultado);
            resultado = im1 / im2;
            Console.WriteLine("{0}/{1}={2}", im1, im2, resultado);
            Console.ReadKey();


            /*****************/
            //Console.WriteLine(im1);
            //im1++;
            //Console.WriteLine(im1);


            //Console.WriteLine(im2);
            //im2--;
            //Console.WriteLine(im2);


            //Console.WriteLine(im1);
            //im1 += im2;
            //Console.WriteLine(im1);

            Cimaginario num1 = new Cimaginario(1, 2);
            Cimaginario num2 = new Cimaginario(2, 2);
            Cimaginario num3 = new Cimaginario(1, 2);

            if (num1 == num3)
                Console.WriteLine("son iguales");
            if (num1 != num2)
                Console.WriteLine("no som iguales");
            if (num1 > num3)
            {
                Console.WriteLine("1 es mayor");
            }
            if (num2 > num1)
            {
                Console.WriteLine("2 es mayor");
            }

            /*La palabra clave implícita se utiliza para declarar un operador implícito de 
            conversión de tipo definido por el usuario. Los operadores de conversión
            implícita pueden ser llamados implícitamente, sin ser especificados por
            versiones explícitas en el código fuente. Elimina moldes innecesarios,
            las conversiones implícitas pueden mejorar la legibilidad del código 
            fuente. El siguiente ejemplo se puede ver que tenemos un CustomType que
            toma el valor Entero como su valor de inicialización y después de
            definir el operador implícito Se convierte directamente castable en int.*/
            Cimaginario ci = new Cimaginario(3, 5);

            int numero = ci;

            Cimaginario strin = new Cimaginario(3, 4);

            string palabra = strin;

            Console.WriteLine(palabra);
            Console.ReadKey();
            //Sin embargo, debido a que las conversiones implícitas pueden ocurrir
            //sin que el programador las especifique, debe tenerse cuidado para evitar
            //sorpresas desagradables. En general, los operadores de conversión 
            //implícita nunca deben lanzar excepciones y nunca perder información 
            //para que puedan ser utilizados de forma segura sin la conciencia del 
            //programador. 
        }
    }
}
