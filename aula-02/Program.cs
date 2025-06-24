namespace aula02;
/*
No C#, as variáveis são declaradas com um tipo de dado que define o que elas podem armazenar. Abaixo estão os principais
 tipos de variáveis em C#, divididos por categoria:

📌 1. Tipos numéricos
🔹 Inteiros:
Tipo	Tamanho	Intervalo	Exemplo
byte	8 bits	0 a 255	byte idade = 20;
sbyte	8 bits	-128 a 127	sbyte valor = -10;
short	16 bits	-32.768 a 32.767	short ano = 2024;
ushort	16 bits	0 a 65.535	ushort porta = 8080;
int	32 bits	-2 bi a 2 bi	int numero = 100;
uint	32 bits	0 a 4 bi	uint positivo = 5000;
long	64 bits	enorme	long populacao = 8000000000;
ulong	64 bits	maior ainda (sem sinal)	ulong total = 9999999999;

🔹 Reais (ponto flutuante):
Tipo	Precisão	Exemplo
float	~7 dígitos	float altura = 1.75f;
double	~15-16 dígitos	double pi = 3.14159;
decimal	~28-29 dígitos	decimal preco = 199.99m; (usado em finanças)

📌 2. Texto e caractere
Tipo	Exemplo
char	char letra = 'A';
string	string nome = "Fabian";

📌 3. Booleano
Tipo	Exemplo
bool	bool ativo = true;

📌 4. Objeto e genéricos
Tipo	Descrição
object	Tipo base de todos os tipos
var	Inferido automaticamente pelo compilador (ex: var idade = 25;)

📌 5. Tipos especiais
Tipo	Usos
dynamic	Tipo dinâmico (determinado em tempo de execução)
nullable	Permite que tipos de valor aceitem null (ex: int? idade = null;)

Se quiser, posso te mandar uma tabela pronta em imagem ou .pdf para usar como consulta. Deseja isso?*/
public class Program
{
  public static void Main()
  
  {
    string nome = "Raul";
    Console.WriteLine(nome);
    int idade = 30;
    Console.WriteLine(idade);
    char character = 'a';
    Console.WriteLine(character);
    bool boolean = true;

  }
}