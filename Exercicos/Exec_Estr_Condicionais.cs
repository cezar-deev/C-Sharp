
                 /* ESTRUTURAS CONDICIONAIS */

//---------------------------- SWITCH CASE---------------------------------------//

using System;
					
public class Program
{
	public static void Main()
	{
		string mes = "Agosto";
		switch (mes)
		{
			case "Janeiro":
			case "Março":
			case "Maio":
			case "Julho":
			case "Agosto":
			case "Outubro":
			case "Dezembro":
								Console.WriteLine("Este mês tem 31 dias");
								break;
			case "Fevereiro":
								Console.WriteLine("Este mês tem 28 ou 29 dias");
								break;
			default:
								Console.WriteLine("Este mês tem 30 dias");
								break;
		}
	}
}
//--------------------------------SWITCH CASE------------------------------------

//Comprando jogos
//Carlos tem 300 reais de saldo no banco e encontrou o jogo que deseja por 120 reais.
//Complete o código utilizando o operador ternário para imprimir no console se ele pode comprar o jogo ou não:
//- A variável "saldo" tem o valor 300;
//- A variável "jogo" tem o valor 120;


using System;
					
public class Program
{
	public static void Main()
	{
		double saldo = 119;
        double jogo = 120;
        Console.WriteLine(saldo >= jogo ? "Pode comprar." : "Não Pode comprar.");
	}
}


//-------------------------------- IF ------------------------------------

using System;
					
public class Program
{
	public static void Main()
	{
		double media = 8;
		string resultado = "Olá aluno, você foi ";
		resultado += media >= 7 ? "aprovado." : "reprovado.";
		Console.WriteLine(resultado);
	}
}


//----------------------------------- SWITCH CASE --------------------------------------------

using System;
					
public class Program
{
	public static void Main()		
	{
		String [] linguagens = {"C#", "Java", "PHP", "Javascript"};
        String linguagem= "PHP";

		switch (linguagem)
		{
			case "C#":
			case "Java":
			  Console.WriteLine("Linguagem Compilada");
			break;

			case "PHP":
			 case "Javascript":
			  Console.WriteLine("Linguagem de Script");
			 break;
		}
	}


//----------------------------------------FOREACH------------------------------------------------------

using System;
					
public class Program
{
	public static void Main()
	{
		string palavra = "Janeiro";
 
		foreach (char caractere in palavra)
		{
		  Console.WriteLine(caractere);
		}
	}
}


//----------------------------------------FOREACH------------------------------------------------------

/*Medalhas recebidas
Complete o código abaixo de acordo com as seguintes instruções:
- Utilize o array medalhas para definir a medalha de cada time;
- O Time A recebeu a medalha de prata;
- O Time B recebeu a medalha de ouro;
- O Time C recebeu a medalha de bronze;*/

using System;
					
public class Program
{
	public static void Main()
	{
		String [] medalhas = {"Bronze", "Prata", "Ouro"};
		
        String time_a = medalhas[1];
		String time_b = medalhas[2];
		String time_c = medalhas[0];
		
		Console.WriteLine( "O time B recebeu a medalha de " + time_b);
		Console.WriteLine( "O time A recebeu a medalha de " + time_a);
		Console.WriteLine( "O time C recebeu a medalha de " + time_c);
		   
	}
}

