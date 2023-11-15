using System.Security.Cryptography;

namespace Traductor
    // traductor hecho por Gómez Ángel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.Write("Ingrese la frase a traducir: ");
            frase = Console.ReadLine().ToLower();
            string[] palabras = frase.Split(' ');
        }

        static string ContieneVocal(string frase)
        {
            string letraUno = frase[0].ToString();
            string letraDos = frase[1].ToString();
            bool control = false;
            char[] letras = { 'a', 'e', 'i', 'o', 'u' };
            if (letraDos.Contains(letras[1]))
            {
                control = true;
            }
            return frase += letraUno;
            
        }
    }
}