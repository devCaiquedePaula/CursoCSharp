using System;

class Aula09_OperadorBitwise
{
    public static void Main(string[] args)
    {
        // Operadores Bitwise
        // & (AND), | (OR), ^ (XOR), ~ (NOT), << (deslocamento à esquerda - dobra), >> (deslocamento à direita - metade)

        int a = 10;  // 1010 em binário
        int b = 26;  // 11010 em binário

        Console.WriteLine("a & b: " + (a & b)); // AND
        Console.WriteLine("a | b: " + (a | b)); // OR
        Console.WriteLine("a ^ b: " + (a ^ b)); // XOR
        Console.WriteLine("~a: " + (~a));       // NOT
        Console.WriteLine("a << 1: " + (a << 1)); // Deslocamento à esquerda
        Console.WriteLine("b >> 1: " + (b >> 1)); // Deslocamento à direita
    }
}