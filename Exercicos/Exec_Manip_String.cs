

//--------------------------------Manipulação de caracter----------------------------------------

using System;
					
public class Program
{
	public static void Main()
	{	
		string data = "10/11/2020";
		
		data = data.Replace ( "/", "-");
		Console.WriteLine(data);
	}
}


//-------------------------------Removendo espaços--------------------------------------------

/* 
                                       
Ao consultar informações de um banco de dados, o desenvolvedor percebeu que alguns nomes de usuários vinham com um espaço no início ou no final do nome.
Qual das alternativas abaixo trata a informação recebida de forma que esses espaços sejam removidos?
*/

using System;
					
public class Program
{
	public static void Main()
	{
       string nomeusuario = "    Carlos Ferreira da Silva ";
       nomeusuario = nomeusuario.Trim(); // Retira espaços o inico e no final
       Console.WriteLine(nomeusuario);
	}
}

//------------------------------------------------------------------------------------


using System;
					
public class Program
{
	public static void Main()
	{	
		
        string [] novidades = {"iPhone 12", "iPhone 12 Pro", "iPhone 12 Mini", "iPhone X", "Galaxy S20 Ultra", "Surfa Duo"};
        
        foreach(string novidade in novidades)
        {    
            if(novidade.Contains("iPhone 12"))
            {    
                Console.WriteLine(novidade.ToUpper());
            }       
			else
			{
				Console.WriteLine(novidade.ToLower());
			}
        }    
    }
}


//-----------------------------------Substituindo palavra----------------------------------------------

/*
Complete o código abaixo utilizando um método de retorno booleano para verificar se a variável do tipo string 'produto' começa com a palavra "Celular", e caso positivo, a palavra "Celular" deve ser substituída por "Smartphone".
No final do código o valor da variável deve ser impresso no console:
*/

using System;
					
public class Program
{
	public static void Main()
	{				
		string produto = "Celular Samsung Galaxy S20";
		if(produto.Contains("Celular")) //Procura se contem a palavra "Celular na var produto
			{ 
				produto = "Smartphone"; // Modifica para "Smartfone"
			}
			Console.WriteLine(produto);	
	}
}

//------------------------------------Soma das notas--------------------------------------------------

/*
Em uma escola foi implementado um sistema que informa ao aluno se ele foi ou não aprovado com base na soma de duas notas.
Utilizando as variáveis criadas abaixo, complete o código de forma que ele mostre no console a mensagem 'Aprovado' se a soma das notas for maior ou igual a 15, do contrário imprime 'Reprovado'.
OBS.: A soma das notas deve ser armazenada em uma variável do tipo inteiro chamada 'soma'.
*/

using System;
					
public class Program
{
	public static void Main()
	{					
		int nota1 = 7;
		int nota2 = 8;
		int soma = nota1 + nota2;
		
			if ( soma >= 15)
			{    
				Console.WriteLine("Aprovado");
			}
			else
			{
				Console.WriteLine("Reprovado");
			}
	}
}


//-----------------------------------retirar parte da palavra----------------------------------


using System;
					
public class Program
{
	public static void Main()
	{					
		string dispositivo = "Smartphone Microsoft Surface Duo";
		Console.WriteLine(dispositivo.Remove(0, 21)); //retira a partie de "zero" , 21 caracteres
	}
}

//---------------------------------
/*
Terminação de uma string
Observe o array abaixo e responda: Qual das alternativas percorre os itens do array e imprime no console apenas os nomes que não terminam em '_000'?
*/

using System;					
public class Program
{
	public static void Main()
	{	
		string[] nomes = {"Carlos_000", "Rodrigo_001", "Marcos_002", "Paulo_000"};
		foreach(string nome in nomes)
	    {
			if(!nome.EndsWith("_000"))
			{
				Console.WriteLine(nome);
			}
	    }			
	}
}