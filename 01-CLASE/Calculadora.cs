using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMenu
{
  //https://github.com/EzequielOggioni/PrimeraClase.git
  public class Calculadora
  {
    int numero1;
    int numero2;
    //int resultado;
    public static int Sumar(int num1, int num2)
    {
      return num1+num2;
    }

    public static int Restar(int num1, int num2)
    {
      return num1 - num2;
    }

    public static int multiplicar(int num1, int num2)
    {
      return num1 * num2;
    }

    public static int dividir(int num1, int num2)
    {
      if (num2 != 0)
      {
        return num1 / num2;
      }
      Console.WriteLine("error no se puede dividir por cero");
      return 0;
    }

    public static void miSwitch(int entero, int num1, int num2)
    {
      switch (entero)
      {
        case 1:
          Console.WriteLine("su resultado es: " + Sumar(num1, num2));
          break;
        case 2:
          Console.WriteLine("su resultado es: " + Restar(num1, num2));
          break;
        case 3:
          Console.WriteLine("su resultado es: " + multiplicar(num1, num2));
          break;
        case 4:
          Console.WriteLine("su resultado es: " + dividir(num1, num2));
          break;
      }
    }




  }
}
