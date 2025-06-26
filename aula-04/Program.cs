namespace aula04;

public class Program {

public static void Main()
{
  Console.WriteLine("Seja bem vindo a caculadora mal programada");


  Console.WriteLine("Digite o primeiro número da operação:");
  int number1= Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Agora digite qual operação deseja fazer?");
  Console.WriteLine("Para Soma: + | para Subtração: - | para Multiplicação: * | para Divisão: / ");
  string sinOperator = Console.ReadLine();
  Console.WriteLine("Digite o segundo número da operação:");
  int number2= Convert.ToInt32(Console.ReadLine());

  int result = 0;
switch(sinOperator)
{
  case "+":
    result = number1+number2;
    break;
  case "-":
    result = number1 - number2 ;
    break;
  case "*":
    result = number1 * number2;
    break;
  case "/" :
    result = number1 / number2;
    break;
}
 

  Console.WriteLine($"O resultado da operação {number1} {sinOperator} {number2} é: {result}");
}

}