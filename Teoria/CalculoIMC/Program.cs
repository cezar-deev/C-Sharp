﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o peso em LK : ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a Altura em Metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Abaixo do Peso");
            }
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Normal");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Acima do Peso");
            }
            else if ((valorIMC >= 30) && (valorIMC = 34))
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Obeso");
            }
            else
            {
                Console.WriteLine("\nIMC = " + valorIMC + "-> Muito Obeso");
            }
        }
    }
}
