using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//GRABACION  

namespace CalculadoraMenu
{
  class Program
  {
    static void Main(string[] args)
    {
      string miPalabra = "";
      int entero;
      int num1;
      int num2;
      int resultado;
      string l;
      //double L = double.Parse(l);
      //siempre tiene q tener el console writeline
      //en el main no en el metodos de laas clases
      //en ese caso esta mal esto se para la logica
      //del negocio con la interface
      do
      {
        Console.WriteLine("Menu");
        Console.WriteLine("1-sumar");
        Console.WriteLine("2-restar");
        Console.WriteLine("3-multiplicar");
        Console.WriteLine("4-dividir");
        Console.WriteLine("ingrese opcion");
        l = Console.ReadLine();
        entero = int.Parse(l);
        Console.WriteLine("ingrese opcion uno");
        l = Console.ReadLine();
        num1 = int.Parse(l);
        Console.WriteLine("ingrese opcion dos");
        l = Console.ReadLine();
        num2 = int.Parse(l);
        //int.TryParse(Console.ReadLine(), out entero);
        Calculadora.miSwitch(entero, num1, num2);

      } while (true);
    }
  }




}
