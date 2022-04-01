
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
//-------------------------------- IF TERNARIO ------------------------------------

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


//-------------------------------- IF TERNARIO ------------------------------------

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


//---------------------------- FOR ---------------------------------------//
// O código abaixo exibe os números ímpares da sequência de 1 a 10.
// Complete o código de forma que toda vez que o número for "Par" a iteração do loop seja pulada.

using System;
					
public class Program
{
	public static void Main()
	{
		for (int x = 1; x <= 10; x++){
		   if(x % 2 == 0)
		   {  
		    continue;
		    }
             Console.WriteLine(x);
         }
	}
}



//---------------------------- SWITCH CASE ---------------------------------------//
/* 
- Dia da semana
- Observe o código abaixo e responda: Qual das alternativas completa o espaço em branco de forma que "Sexta-Feira" seja impresso no console?
*/

int dia_semana = 5;

string dia = "";

switch (dia_semana)
{
    case 0:
            dia = "Domingo";
    break;
    case 1:
        dia = "Segunda-Feira";
    break;
    case 2:
        dia = "Terça-Feira";
    break;
    case 3:
        dia = "Quarta-Feira";
    break;
    case 4:
        dia = "Quinta-Feira";
    break;
    case 5:
        dia = "Sexta-Feira";
    break;
    case 6:
        dia = "Sábado";
    break;
}

Console.WriteLine(dia);


//-------------------------------- TERNARIO ------------------------------------

/*
                              Aprovado ou Recusado
Escreva abaixo uma condição utilizando operador ternário de acordo com as instruções da lista abaixo:

- A condição deve verificar se a variável 'limite' é maior ou igual a 'valor';
- Caso seja, o texto "Aprovado" deve ser retornado, do contrário o texto "Recusado" deve retornar;
- Toda essa operação deve estar associada a uma variável do tipo string chamada 'compra'.
*/

using System;
					
public class Program
{
	public static void Main()
	{	
		int valor = 10;
	    int limite = 10;
		
		string compra = (limite >= valor ? "Aprovado" : "Recusado");
		Console.WriteLine(compra);
	}
}
