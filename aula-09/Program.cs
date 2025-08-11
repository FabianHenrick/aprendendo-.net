namespace aula09;

public class Program
{
  public static void Main()
  {
    //1. Declaração de Array.
    string[] fruits = { "maçã", "banana", "manga", "melao", "morango" };

    //2. Acessar os Valores
    foreach (string fruit in fruits)
    {
      Console.WriteLine(fruit);

    }

    // 3. Contagem de Índices.
    Console.WriteLine("Quantidade de Índices: " + fruits.Length);

    //4. Alterar os Valores
    Console.WriteLine("valor antes da alteração: " + fruits[1]);
    fruits[1] = "abacaxi";
    Console.WriteLine("valor depois da alteração: " + fruits[1]);

    //5. Declaração sem inicializar
    int[] numbers = new numbers[3];

    foreach (int number in numbers)
    {
      Console.WriteLine(number);
    }
  }
}