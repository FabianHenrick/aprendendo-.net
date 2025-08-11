namespace Aula08;

public class Program
{
  public static void Main()
  {
    // Coleções (listas)}
   // A melhor tradução para assimilação do foreach é o "Para cada"
    List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
  
    foreach (int number in numberList){
      //Neste exemplo, para cada numero inteiro dentro de number list, ele vai executar o código.
      Console.WriteLine(number);
    };
}}