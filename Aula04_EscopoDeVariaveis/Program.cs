using System;

namespace Aula03_EscopoDeVariaveis
{
    internal class Program
    {
        // Escopo de Classe
        // Variáveis declaradas numa classe, mas fora de qualquer método, são acessíveis por todos os métodos da classe
        private int classVariable = 100;
        private void DisplayClassVariable()
        {
            Console.WriteLine("Valor da variável de classe: " + classVariable);
        }
        // Escopo de Método
        // Variáveis declaradas num método só podem ser acessadas dentro desse método
        private void DisplayMethodVariable()
        {
            int methodVariable = 50;
            Console.WriteLine("Valor da variável de método: " + methodVariable);
        }

        static void Main(string[] args)
        {
            //Escopo de Variáveis
            //Variáveis declaradas num bloco só podem ser acessadas dentro desse bloco
            {
                int x = 10;
                Console.WriteLine("Valor de x dentro do bloco: " + x);
            }

            //Console.WriteLine("Valor de x fora do bloco: " + x); // Isso causaria um erro, pois x não está acessível aqui
            int y = 20;
            Console.WriteLine("Valor de y fora do bloco: " + y);

            // Variáveis declaradas fora de um bloco podem ser acessadas dentro de blocos aninhados
            {
                int z = 30;
                Console.WriteLine("Valor de z dentro do bloco aninhado: " + z);
                Console.WriteLine("Valor de y dentro do bloco aninhado: " + y);
            }
        }
    }
}