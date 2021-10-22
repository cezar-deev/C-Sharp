using System;

public class Logicos
{
    public static void Main()
    { 
        int unario = 0;
        int preIncremento;
        int preDecremento;
        int posIncremento;
        int posDecremento;
        int positivo;
        int negativo;
        sbyte bitNao;
        bool logNao;
        
        preIncremento = ++unario;
        
        Console.WriteLine("Pré-Incremento            : {0}",preIncremento);
        Console.WriteLine("Unário                    : {0}",unario);
        Console.WriteLine(" ");
        
        preDecremento = --unario;
        
        Console.WriteLine("Pré-Decremento            : {0}",preDecremento);
        Console.WriteLine("Unário                    : {0}",unario);
        Console.WriteLine(" ");
        
        posDecremento = unario--;
        
        Console.WriteLine("Pós-Decremento            : {0}",posDecremento);
        Console.WriteLine("Unário                    : {0}",unario);
        Console.WriteLine(" ");
        
        posIncremento = unario++;
        
        Console.WriteLine("Pós-Incremento            : {0}",posIncremento);
        Console.WriteLine("Unário                    : {0}",unario);
        Console.WriteLine(" ");
        
        Console.WriteLine("Valor Final do Unário     : {0}",unario);
        Console.WriteLine(" ");
        
        
        positivo = -posIncremento;
        Console.WriteLine("Positivo                  : {0}" , positivo);
        
        negativo = +posIncremento;
        Console.WriteLine("Negativo                  : {0}" , negativo);
        Console.WriteLine(" ");
        
        
        
    }
}