using System;

class Aula03Variaveis
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        int idade = 26;
        char letra = 'A';
        float peso = 100.5f; // float deve ter 'f' no final
        string nome = "Caique";
        double altura = 1.80;
        bool estudante = true;
        
        // Operador VAR 
        var cidade = "São Paulo"; // Tipo inferido como string

        // Exibição das variáveis
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Letra: " + letra);
        Console.WriteLine("Peso: " + peso + " kg");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("É estudante? " + estudante);
        
        Console.WriteLine("Cidade: " + cidade);
    }
}
