using System;
public class Hello{
    public static void Main(){       // Your code here!
        string framework= "ASP.NET MVC";
        char ponto = framework[3];
        Console.WriteLine(ponto);
    }
}

//-------------------------------------------------------------


using System;
        enum TipoMascote {
          Cachorro,
          Gato,
          Lhama
        }
        
        public class exercico {
           static void Main(string[] args) {
           string mascote_nome = "Felix";
           int mascote_idade = 5 ;
           TipoMascote mascote_tipo = TipoMascote.Lhama;
           Console.WriteLine("Situação: " + TipoMascote.Lhama.ToString());
           }
       }


       //-------------------------------------------------------------

int a = 10, b = 20, c = 30, d = 40;

Console.WriteLine(c < d);
Console.WriteLine(!(a > d));
Console.WriteLine(c > a * 2 && b == 20);
Console.WriteLine(b > a && b > c);
Console.WriteLine(a + c == d);


 //-------------------------------------------------------------


 using System;
public class Hello{
    public static void Main(){
        string nome = "Framework";
        int tamanho = nome.Length;
        Console.WriteLine("A palavra " + nome + " possui " + tamanho + " letras.");
    }
}


 //-------------------------------------------------------------

 using System;
public class Hello{
     static void Main(string[] args) {
     int lampadas_acesas = 5;
     int lampadas_queimadas = 3;
     int total = lampadas_acesas + lampadas_queimadas;
     Console.WriteLine("Tota de Lamapadas da casa é: " + total);
     }
}