using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implicita
            //byte num1 = 100; // 8 bits, de 0 a 244
            //ushort num2; // 16 bits, de 0 a 65000

            //float num3 = 1250.45f;
            //double num4 = num3;


            //num3 = num1
            //num2 = num1;

            //int numero = 'C';

            //Console.WriteLine(num2);
            //Console.ReadKey();
            #endregion

            #region Conversão Explicita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            //char letra = (char)97;

            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            #region Conversão Metodo Parse

            string txtNumero = "1988";

            int numero = int.Parse(txtNumero);

            byte numero = byte.Parse("128")

            double num2 = double.Parse("123456,45");

            float nume3 = float.Parse("457");

            Console.WriteLine(num2);
            Console.ReadKey();
            #endregion

            #region Conversão Metodo Convert
            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(0);

            Console.WriteLine(num1);
            Console.ReadKey();
            #endregion

        }
    }
}
