using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CLASE
{
  class Program
  {
    static int entero=3;
    static bool boleano;
    static double doble;
    static string miPalabra;//diferencia entre
    //String objeto es que
    //tengo que pasarle un objeto en este string no
    //String lalal = "";//mal hecho
    //entero=5;//mal salta error
    //xq tenemos q poneer static ??
    static void Main(string[] args)//Entry point
    {
      entero = 5;
      //:10:00 muy importante casteo
      //decimal forma explicita y implicita
      //entero = doble;//salta error xq pierde errore
      entero = (int)doble;
      doble = entero;
      //entero = int.Parse(miPalabra);
      if(int.TryParse(miPalabra,out entero));

      miPalabra = boleano.ToString();//tenemos que pasarlo
      //a toString para guardarlo
      //18:00termino teoria de combercion explicita
      System.Console.WriteLine(miPalabra);
      Console.ReadKey();
      ConsoleKeyInfo cki = Console.ReadKey();
      Console.WriteLine(cki.Key);
    }
  }
}
