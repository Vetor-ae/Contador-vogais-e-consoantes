using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o que quiser(palavras, frases, sentencas,...):");
        string frase = Console.ReadLine().ToLower();
        char[] vogais = ['a', 'e', 'i', 'o', 'u'];
        int vog = 0;
        int cons = 0;
        foreach (char caracter in frase)
        {
            for (int i = 0; i < vogais.Length; i++)
            {
                if (caracter == vogais[i])
                {
                    vog++;
                }
                else
                {
                    cons++;
                } 
            }
        }
        Console.WriteLine($"Qnt. de vogais = {vog}\nQnt. de consoantes = {cons}");
    }
}