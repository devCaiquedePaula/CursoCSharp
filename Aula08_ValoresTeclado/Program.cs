using System;

class Aula08_ValoresTeclado
{
    static void Main(string[] args)
    {
        int v1, v2, soma;
        string nome;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        
        Console.WriteLine("Olá {0}, a soma de {1} e {2} é igual a {3}", nome, v1, v2, soma);
    }
}