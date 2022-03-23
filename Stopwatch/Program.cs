// See https://aka.ms/new-console-template for more information

using System.Threading;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S - Segundo => 10s = 10 seguntos");
    Console.WriteLine("M - Minutos => 1m = 1 minuto");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Quanto tempo deseja contar ?");

    string data = Console.ReadLine().ToLower();
    Console.WriteLine(data);
    
}

static void Start( int time) 
{
   int currentTime = 0;
   
   while (currentTime != time)
   {
      Console.Clear(); 
      currentTime++;
      Console.WriteLine(currentTime);
      Thread.Sleep(1000);
   }

   Console.Clear();
   Console.WriteLine("stowatch finalizado");
   Thread.Sleep(2500);

}