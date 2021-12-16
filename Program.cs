using System;

namespace Vigener_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shifrator();
            Deshifrator();
        }
        static void Shifrator()
        {
            
            string result = "";
            Console.WriteLine("Введите текст");
            Console.WriteLine("Можно использовать буквы русского и английского алфавита ");
            string Phrase = Console.ReadLine();
            Phrase = Phrase.Replace(" ", "").ToLower();
            char[] phrase = Phrase.ToCharArray();
            Console.WriteLine("Введите ключ");
            Console.WriteLine("Можно использовать буквы русского и английского алфавита");
            string Key = Console.ReadLine();
            Key = Key.Replace(" ", "").ToLower();
            char[] key = Key.ToCharArray();
            string alfabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            char[,] vigener = new char[alfabet.Length, alfabet.Length];
            for (int n = 0; n < alfabet.Length; n++)
            {
                for (int m = 0; m < alfabet.Length; m++)
                {
                    int positionAlfabet = (m + n) % alfabet.Length;
                    vigener[n, m] = alfabet[positionAlfabet];
                }
            }
            
            int param1 = 0;
            int param2 = 0;
            string keyPhrase = "";
            for( int i = 0; i < phrase.Length; i++)
            {
                keyPhrase += key[i % key.Length];
            }
            for (int i = 0; i < phrase.Length; i++)
            {
                for (int x = 0; x < alfabet.Length; x++)
                {
                    if (vigener[x, 0] == phrase[i])
                    {
                        param1 = x;
                    }
                }
                for (int y = 0; y < alfabet.Length; y++)
                {
                    if (vigener[y, 0] == keyPhrase[i])
                    {
                        param2 = y;
                    }
                }
                result += vigener[(param1 + param2) % alfabet.Length, 0];
            }
            Console.WriteLine($"Результат шифрования: {result}") ;
        }
        static void Deshifrator()
        {
            string result = "";
            Console.WriteLine("Введите текст");
            Console.WriteLine("Можно использовать буквы русского и английского алфавита ");
            string Phrase = Console.ReadLine();
            Phrase = Phrase.Replace(" ", "").ToLower();
            char[] phrase = Phrase.ToCharArray();
            Console.WriteLine("Введите ключ");
            Console.WriteLine("Можно использовать буквы русского и английского алфавита");
            string Key = Console.ReadLine();
            Key = Key.Replace(" ", "").ToLower();
            char[] key = Key.ToCharArray();
            string alfabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            char[,] vigener = new char[alfabet.Length, alfabet.Length];
            for (int n = 0; n < alfabet.Length; n++)
            {
                for (int m = 0; m < alfabet.Length; m++)
                {
                    int positionAlfabet = (m + n) % alfabet.Length;
                    vigener[n, m] = alfabet[positionAlfabet];
                }
            }

            int param1 = 0;
            int param2 = 0;
            string keyPhrase = "";
            for (int i = 0; i < phrase.Length; i++)
            {
                keyPhrase += key[i % key.Length];
            }
            for (int i = 0; i < phrase.Length; i++)
            {
                for (int x = 0; x < alfabet.Length; x++)
                {
                    if (vigener[x, 0] == phrase[i])
                    {
                        param1 = x;
                    }
                }
                for (int y = 0; y < alfabet.Length; y++)
                {
                    if (vigener[y, 0] == keyPhrase[i])
                    {
                        param2 = y;
                    }
                }
                result += vigener[(param1 + alfabet.Length -  param2) % alfabet.Length, 0];
            }
            Console.WriteLine($"Результат шифрования: {result}");
        
    }
    }
}
