using System;

namespace Curso_de_Csharpe
{
    class Program
    {
        enum notas
        {
            Minimo = 10, 
            Media = 20, 
            Máxima = 40
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main()
        {
            #region String - Cadeia de Caractéres 
            //string texto = " Cezar dos santos \n Cardoso 2#$1981 ";
            //string mensagem = null;
            //mensagem = texto;
            //Console.WriteLine(mensagem);
            //Console.ReadKey();
            #endregion

            #region Tipo Implicito Var
            //var valor = 100; // Nao tem tipo definido até que receba o primeiro valor
            //valor = 20;
            //valor = " cezar" // nao aceita uma string,pois seu primeiro valor foi um inteiro ( 100 )

            //Console.WriteLine();
            //Console.ReadLine();
            #endregion

            #region Tipo Object - Tem base para todos os tipos
            //object obj = false; // Esse tipo de variavel comportar todos os tipos de variaveis; 
            //obj = 100;  // Não assume nenum tipo ( inteiro,string chaetc ) , pois trata todo valor recebido como objeto;
            //obj = "cezar";
            #endregion

            #region Constantes - Tipo que não é variavel, pois é Constante
            //const double pi = 3,1415; // quando precisamos definiri um valor que ninguem pode alterar, 
            //const string nome = "Cezar"; // usamos usamos o tipo const, pois esse valor não pode variar.
            #endregion

            #region Enumerações -
            //notas notasAluno = notas.Media;
            #endregion

            #region Struct - 
            //Pessoa p1 = new Pessoa();  // Forma 1 de Fazer uma estrutura de dados

            //p1.nome = "Cezar";
            //p1.idade = 40;
            //p1.altura = 1.80;

            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.idade);
            //Console.WriteLine(p1.altura);


            //Pessoa p2 = new Pessoa() // Forma 2 de Fazer uma estrutura de dados
            //{
            //    nome = "Cezar",
            //    idade = 40,
            //    altura = 1.80
            //};

            //Console.WriteLine(p2.nome);
            //Console.WriteLine(p2.idade);
            //Console.WriteLine(p2.altura);

            #endregion
        }
    }
}
