using System;
/*
4) Descubra a lógica e complete o próximo elemento:
a) 1, 3, 5, 7, ___
b) 2, 4, 8, 16, 32, 64, ____
c) 0, 1, 4, 9, 16, 25, 36, ____
d) 4, 16, 36, 64, ____
e) 1, 1, 2, 3, 5, 8, ____
f) 2,10, 12, 16, 17, 18, 19, ____

*/
class Program
{
    static void Main()
    {
        // Solicitar a entrada do usuário
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();

        // Inicializar o contador para a quantidade de letras 'a' e 'A'
        int count = 0;

        // Percorrer cada caractere da string
        foreach (char c in input)
        {
            // Verificar se o caractere é 'a' ou 'A'
            if (c == 'a' || c == 'A')
            {
                count++;
            }
        }

        // Exibir o resultado
        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vezes.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada.");
        }
    }
}
