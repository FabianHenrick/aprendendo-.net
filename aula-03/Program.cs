namespace aula03;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("---------------CADASTRO DE USUÁRIOS---------------");
    //Solicitar o nome do Usuario.
    Console.WriteLine("Digite seu nome:");
    string name = Console.ReadLine();
    Console.WriteLine("Digite sua idade:");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite seu e-mail:");
    string email = Console.ReadLine();

    Console.WriteLine($"Seja bem vindo {name}, você tem {age} anos, seu email é : {email}");
    
  }
}