namespace Aula07;

public class Program
{
  public static void Main()
  {
    /*
    for (condição 1; condição 2; condição 3;)

    condição 1 é executada (uma única vez) antes da execução do bloco de código.

    condição 2 define a condição para executar o bloco de código.

    condição 3 é executado (todas as vezes) após o bloco de código ter sido executado.
    */
    //Ex1
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine(i);
    }
    //Ex2:
    Console.WriteLine("######Tabela de Mutiplicação######");
    for (int i = 1; i <= 10; i++)
    {
      for (int j = 1; j <= 10; j++)
      {
        Console.WriteLine($"{i} - {j} = {i * j},");
      }
    }
  }
}