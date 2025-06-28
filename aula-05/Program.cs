namespace aula05;

   public class Program
   {

      public static void Main()
      {
        Console.WriteLine("######### Verificador de Numeros Pares e Impares #########");
        Console.WriteLine("Digite um número:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        if(number1 % 2 == 0 )
        {
          Console.WriteLine($"o número {number1} é par");
        }else
        {
          Console.WriteLine($"o número {number1} é impar");
        }
      }

    }
