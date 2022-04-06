
//--------------------------------ARRAY-------------------------

using System;	
public class Program
{
	public static void Main()
	{
		String [] medalhas = {"Bronze", "Prata", "Ouro"};

		string time_a = medalhas[1];
		string time_b = medalhas[2];
		string time_c = medalhas[0];

		Console.WriteLine("O time B recebeu a medalha de " + time_b);
		Console.WriteLine("O time A recebeu a medalha de " + time_a);
		Console.WriteLine("O time C recebeu a medalha de " + time_c);
	}	
}


//----------------------------USANDO FOR-------------------------

/* Complete o código para criar e percorrer um array de acordo com os pedidos da lista:

- Criar um array do tipo string chamado 'estados' com limite de dois itens e valores "Correto" e "Incorreto" definidos no momento da declaração
- Criar um loop for com base no tamanho do array(utilizar Length)
- Imprimir no console os valores do array
*/

using System;				
public class Program
{
	public static void Main()
	{		
		string [] estados = new string [2] {"Correto", "Incorreto"};
        for(int i = 0; i < estados.Length ; i++)
         {
            Console.WriteLine(estados[i]);
		 }				
	}
}


//----------------------------USANDO FOR-------------------------

/* Utilizando o array de nome 'tecnologia', escreva um código capaz de imprimir o valor "Oracle" no Console: */

using System;					
public class Program
{
	public static void Main()
	{		
		string[] tecnologia = {"Apple", "Microsoft", "Oracle", "Amazon"};

        for(int i = 0; i < tecnologia.Length ; i++)
        {
			string tec = tecnologia[2];
			if ( tec == "Oracle") 
			{
               Console.WriteLine(tecnologia[2]);
			}
	    break;		
		}				
	}
}

//----------------------------OU DE FORMA MAIS SIMPLES-------------------------

using System;					
public class Program
{
	public static void Main()
	{		
		string[] tecnologia = {"Apple", "Microsoft", "Oracle", "Amazon"};
			
        Console.WriteLine(tecnologia[2]);	
	 				
	}
}


//-----------------------------------USANDO IF---------------------------------

/* 
- Deixar o conteúdo da variável 'produto' com todas as letras minúsculas;
- Verificar se o valor do produto é igual a 'tv', e caso seja, deixar o conteúdo com todas as letras maiúsculas; 
*/

using System;					
public class Program
{
	public static void Main()
	{
		string produto = "Tv";
		produto = produto.ToLower();
		
        if(produto.Equals("tv"))
        {
		    produto = produto.ToUpper();
			Console.WriteLine(produto);	
		}
		
		
	}
}

//-----------------------------------USANDO FOR E IF---------------------------------

/*
-Nomes que começam com a letra A
-Percorra o array abaixo e imprima todos os nomes no console, verificando para que nomes que comecem com a letra A tenham todas as letras maiúsculas:
*/

using System;					
public class Program
{
	public static void Main()
	{	
		string[] nomes = {"Tiago", "Juliana", "Ana Paula", "Carlos", "Amanda"};
		
	    for(int i= 0; i < nomes.Length; i++)
	    {	
		     if(nomes[i].Contains("A"))
			 {
				nomes[i] = nomes[i].ToUpper();
			 }
			 Console.WriteLine(nomes[i]);
	    }				
	}
}

//-----------------------------------Usando o LastIndexOf---------------------------------
/*
                                  
								  - Removendo a última vírgula
								  
Enquanto observava seu código, o desenvolvedor percebeu que o resultado da string 'pessoas' vinha com uma vírgula extra no final.
Qual das alternativas abaixo remove essa vírgula e imprime o resultado correto?
*/

using System;
					
public class Program
{
	public static void Main()
	{	
		string pessoas = "Diego, Cleber, Fernanda , Gustavo,";
		
		pessoas = pessoas.Remove(pessoas.LastIndexOf(','),1);
		Console.WriteLine(pessoas);		
	}
}

//--------------------------------------------------------------------------------------------------

/* 
                                        Sistema de contagem de votos

Um sistema de votação contabiliza e armazena todos os votos em um array. Utilize as informações da lista abaixo para construir um código capaz de contabilizar os votos de cada candidato:

- Utilizando um for, percorra todo o array utilizando uma variável de tipo int e nome 'i' inicializada em '0' para o incremento do loop;
- O loop deve ser executado enquanto 'i' for menor que o tamanho do array (utilize a propriedade adequada para capturar o tamanho do array;
- Feito isso, escreva uma condicional if que identifique se o valor do voto é "X" ou "Y" para cada item do array;
- Caso o valor seja "X" a variável votoX deve ser incrementada em 1;
- Caso o valor seja "Y" a variável votoY é quem deve ser incrementada em 1.
*/

using System;				
public class Program
{
	public static void Main()
	{	
		string[] votos = {"X", "Y", "X", "X", "Y" ,"X", "Y", "Y", "X", "X", "X"};

		int votoX = 0;
		int votoY = 0;

		for ( int i=0; i < votos.Length; i++)
		{
			if ( votos[i] == "X")
			{
			   votoX++;
			}
			else
			{       
			   votoY++;
			}	
		}
		Console.WriteLine("Resultado:");		
		Console.WriteLine("Votos em X: " + votoX);
		Console.WriteLine("Votos em Y: " + votoY);			
	}
}






