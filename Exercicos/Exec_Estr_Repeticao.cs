//-------------------------------ESTRUTURA DE REPETIÇÃO : DO WHILE -------------------------------------


	public static void Main()
	{
		int ano = 0;
		double salario = 1700;
		do
		{
			salario += 50;
			ano++;
		} 
		while (ano < 3);
		Console.WriteLine(salario);
				
	}
}

//-------------------------------- WHILE ------------------------------------

string[] marcas = {"Coca-cola", "Pepsi", "Tobi", "Convenção"};
int i = 0;

while(i < marcas.Length)
	{
	Console.WriteLine(marcas[i]);
	i++;
}



//-------------------------------- WHILE ------------------------------------

//O código abaixo deve imprimir os jogos que estão dentro do array "jogos".
//Qual das opções preenche as lacunas corretamente:

using System;
					
public class Program
{
	public static void Main()
	{	
		string[] jogos = {"Demon's Souls", "Dark Souls", "Bloodborne", "Sekiro"};
		int i = 0;

		while (i < jogos.Length)
        {
           Console.WriteLine(jogos[i]);
           i++;
        }

    }
		
}



//-------------------------------- USANDO FOR ------------------------------------

using System;
					
public class Program
{
	public static void Main()
	{
		string [] series = {"The Boys", "Stranger Things", "100 dias de Dev", "Supernatural", "The Office"};   

		for (int i = 0; i < series.Length ; i++)
        {
           Console.WriteLine(series[i]);
        }

	}
}

//-------------------------------- USANDO FOR ------------------------------------

using System;
					
public class Program
{
	public static void Main()		
	{
		int pontos = 20;
		for (int rodada = 12 ; rodada<=30; rodada++)
		{
			pontos += 3 ;
		}		
		
		Console.WriteLine(pontos);
	}
}


//-------------------------------- USANDO FOReach ------------------------------------
/* O código abaixo imprime o nome dos itens do array "lista" caso eles tenham sete letras ou menos.
Complete as lacunas para que o código execute corretamente: */


using System;					
public class Program
{
	public static void Main()
	{
		string [] lista = {"celular", "notebook", "modem", "nobreak", "monitor"};
        
		foreach(string objeto in lista)
        {   
        	if(objeto.Length <= 7) 
			{        
	        	Console.WriteLine(objeto);
            }
	    }
    }
}


//-------------------------------- USANDO FOReach ------------------------------------
/* O código abaixo itera por um array até encontrar um nome com menos de 6 letras.
Complete as lacunas para que o código funcione corretamente: */


using System;
					
public class Program
{
	public static void Main()
	{		
	   string [] nomes = {"Victor", "Mateus", "Diego", "Eduardo", "Fernando"};	  
		foreach (string n in nomes)
		{
			if(n.Length <= 6)
			{
				Console.WriteLine(n+ " possui menos de 6 letras!");
				break;
			}
		}		
    }	
}





using System;
					
public class Program
{
	public static void Main()
	{
		string [] series = {"The Boys", "Stranger Things", "100 dias de Dev", "Supernatural", "The Office"};   
  
			Console.WriteLine("--------------------for---------------------------");
			
			for (int i = 0; i < series.Length ; i++)
			{
			Console.WriteLine(series[i]);
			}
			
			Console.WriteLine("--------------------while---------------------------");
			
			int x = 0;
			while ( x < series.Length)
			{
			Console.WriteLine(series[x]);
			x++;		
			}	
			
			Console.WriteLine("--------------------foreach--------------------------");
			
			foreach ( string serie in series) 
			{
				Console.WriteLine(serie);
			}		
		
			Console.WriteLine("--------------------do while------------------------");
			
			int y = 0;
			do 
			{
				Console.WriteLine(series[y]);
				y++;
			}
			while ( y < series.Length);
					
	}
}