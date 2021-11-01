using System;

class teste_Vetor
{
    public static void Main()
    {
       string[] VetNome = new string[3]; //Declaração
    
       VetNome[0] = "Ana";
       VetNome[1] = "Cezar";
       VetNome[2] = "Alicia";
    
       for (int x=0;x<=2;x++)
       {
         Console.WriteLine("Nome {0} = {1}", x,VetNome[x]);
       }
    }   
}