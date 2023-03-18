using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine("O resultado da soma é " + resultado);

        }
    }
}

/*
criar um static void Soma()
invocar ele no main
criar um static void Subtracao()
colocar o Console.readkey
criar um static voide Divisao()
criari um static void Multiplicacao()
criar um static void Menu()
no final de cada função colocar o Menu()
criar a opção sair com o System.Enviroment.Exit(0)
*/