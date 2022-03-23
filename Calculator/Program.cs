// See https://aka.ms/new-console-template for more information


Menu();

static void Menu()
{
   //Console.Clear();

    Console.WriteLine("O que Deseja Fazer ?");
    Console.WriteLine("1 -Soma");
    Console.WriteLine("2 -Subtração");
    Console.WriteLine("3 -Divisão");
    Console.WriteLine("4 -Multiplicação");
    Console.WriteLine("5 -Sair");

    Console.WriteLine("--------------------------");
    Console.WriteLine("Selecione uma Opção");
    short res = short.Parse(Console.ReadLine());

    switch (res) 
    {
       case 1: Soma();break;
       case 2: Subtracao();break;
       case 3: Divisao();break;
       case 4: Multiplicacao();break;
       case 5: System.Environment.Exit(0);break;
       default: Menu();break;
    }
}


static void Soma()
{
   //Console.Clear();
   Console.WriteLine(" Calculo de Soma");

    Console.WriteLine("primeiro valor :");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("primeiro valor :");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 +v2;

    //Console.WriteLine("O resultado da soma é :" + resultado); // Opção 1
    //Console.WriteLine("O resultado da soma é :" + ( v1+ v2)); // Opção 2
    //Console.WriteLine($"O resultado da soma é :{resultado}"); // Opção 3
    Console.WriteLine($"O resultado da soma é :{v1 + v2}");  // Opção 4 
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    //Console.Clear();
    Console.WriteLine(" Calcular Subtracao ");

    Console.WriteLine("Digite o 1° valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2° valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1- v2;
    Console.WriteLine($"Resultado : {resultado}");
    Console.ReadKey();
    Menu();

}

static void Divisao()
{
    //Console.Clear();
    Console.WriteLine("Calcular a Divisao");

    Console.WriteLine("Digite o 1° valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2° valor");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1/v2;
    Console.WriteLine($"O resultado e:{resultado}");
    Console.ReadKey();
    Menu();


}

static void Multiplicacao()
{
    //Console.Clear();
    Console.WriteLine("Calcular a Multiplicacao");

    Console.WriteLine("Digite o 1° valor:");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 2° valor");
    float v2 = float.Parse(Console.ReadLine());

    float resultado = v1*v2;
    Console.WriteLine($"O resultado e:{resultado}");
    Console.ReadKey();
    Menu();

}

