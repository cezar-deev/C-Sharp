// See https://aka.ms/new-console-template for more information
using System.IO;

Menu();

static void Menu() {
    Console.Clear();
    Console.WriteLine("O que você deseja Fazer ?");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair"); 
    short option = short.Parse(Console.ReadLine());

    switch(option) 
    {
        case 0 : System.Environment.Exit(0); break;
        case 1 : Abrir();break;
        case 2 : Editar();break;
        default : Menu();break;
    }
}

static void Abrir()
{
   Console.Clear();
   Console.WriteLine("Qual caminho do arquivo");
   string caminho = Console.ReadLine();

   using( var file = new StreamReader(caminho)) // Using abre e fecha um arquivo
   {
        string text = file.ReadToEnd(); // Lê o arquivo ate o final
        Console.WriteLine(text);
   }

   Console.WriteLine("");
   Console.ReadLine();
   Menu();

}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo(Esc para Sair)");
    Console.WriteLine("--------------------------------------");
    String text = "";
    
    do{
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while(Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);

}

static void Salvar(string text) 
{
   Console.WriteLine("Qual caminho para salvar o arquivo ? ");
   var caminho = Console.ReadLine();

    using( var file = new StreamWriter(caminho))
    {
        file.Write(text);

    }

    Console.WriteLine($"arquivo {caminho}savo com sucesso");
    Menu();
}