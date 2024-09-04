using System;
using System.Text;
/*
2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
*/
class Program
{
    static void Main()
    {
        // Solicitar a entrada do usuário
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();

        // Normalizar a string para remover acentos (decomposição Unicode)
        string normalizedInput = input.Normalize(NormalizationForm.FormD);
        int count = 0;

        // Percorrer cada caractere da string normalizada
        foreach (char c in normalizedInput)
        {
            // Verificar se o caractere é 'a' ou 'A'
            if (char.ToLower(c) == 'a')
            {
                count++;
            }
        }

        // Exibir o resultado
        Console.WriteLine($"A letra 'a' aparece {count} vezes.");
    }
}
