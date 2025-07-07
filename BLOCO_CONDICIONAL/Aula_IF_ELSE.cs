namespace BLOCO_CONDICIONAL;

class Aula_IF_ELSE
{
    public static void Executar()
    {
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Verificando a idade...");
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}