using System; 

class Aula11_ConversoesDeTipos
{
    static void Main(string[] args)
    {
        // Conversão implícita
        int numeroInteiro = 10;
        double numeroDouble = numeroInteiro; // int para double

        Console.WriteLine("Conversão implícita de int para double: " + numeroDouble);

        // Conversão explícita
        double numeroDecimal = 9.78;
        int numeroConvertido = (int)numeroDecimal; // double para int

        Console.WriteLine("Conversão explícita de double para int: " + numeroConvertido);
    }
}