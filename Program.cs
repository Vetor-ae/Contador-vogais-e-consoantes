using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o que quiser(palavras, frases, sentencas,...):");
        string frase = Console.ReadLine().ToLower();
        char[] exc = [' ', ',', '.'];
        int vog = 0;
        int cons = 0;
        string[] lunch = frase.Split(exc);
        foreach (string pal in lunch)
        {
            foreach (char caracter in pal)
            {
                if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
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