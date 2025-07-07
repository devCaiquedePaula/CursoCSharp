using System; 

class Aula10_Enums
{
    enum DiasDaSemana
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    };

    static void Main(string[] args)
    {
        DiasDaSemana dia = DiasDaSemana.Quarta;
        Console.WriteLine($"Hoje é {dia}.");
        
        // Exemplo de conversão de enum para inteiro
        int diaComoInteiro = (int)dia;
        Console.WriteLine($"O dia {dia} é representado pelo número {diaComoInteiro}.");
        
        // Exemplo de conversão de inteiro para enum
        int numeroDoDia = 1; // Segunda-feira
        DiasDaSemana diaConvertido = (DiasDaSemana)numeroDoDia;
        Console.WriteLine($"O número {numeroDoDia} corresponde ao dia {diaConvertido}.");
    }
}