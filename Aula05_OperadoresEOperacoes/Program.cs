using System;

class Aula05_OperadoresEOperacoes
{
    static void Main(string[] args)
    {
        // Operadores Aritméticos
        int a = 10;
        int b = 5;

        Console.WriteLine("Soma: " + (a + b));
        Console.WriteLine("Subtração: " + (a - b));
        Console.WriteLine("Multiplicação: " + (a * b));
        Console.WriteLine("Divisão: " + (a / b));
        Console.WriteLine("Módulo: " + (a % b));

        // Operadores de Comparação
        Console.WriteLine("Igualdade: " + (a == b));
        Console.WriteLine("Desigualdade: " + (a != b));
        Console.WriteLine("Maior que: " + (a > b));
        Console.WriteLine("Menor que: " + (a < b));
        Console.WriteLine("Maior ou igual a: " + (a >= b));
        Console.WriteLine("Menor ou igual a: " + (a <= b));

        // Operadores Lógicos
        bool x = true;
        bool y = false;

        Console.WriteLine("AND lógico: " + (x && y));
        Console.WriteLine("OR lógico: " + (x || y));
        Console.WriteLine("NOT lógico: " + (!x));

        // Operadores de Atribuição
        int c = 20;
        c += 5; // c = c + 5
        Console.WriteLine("Atribuição com adição: " + c);
    }
}
