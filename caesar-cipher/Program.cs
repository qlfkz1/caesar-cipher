using System;
using System.Text.RegularExpressions;

namespace caesar_cipher
{
    class Program
    {

        static string Encrypt(string message, int key)
        {
            foreach (var i in message)
            {
                int index = char.ToUpper(i) - 64;
                Console.Write(index);
            }

            s
            string cipher_text = "";
            
        }

        static string Decrypt(string cipher_text, int key)
        {

            string plain_text = "";

            return plain_text;
        }

        static string BruteForce(string cipher_text)
        {

            string plain_text = "";

            return plain_text;
        }

        static void MainMenu()
        {
            int chosen;


            Console.WriteLine("Caesar Cipher");
            Console.WriteLine();

            Console.Write("Would you like to:\n[1] Encrypt\n[2] Decrypt\n\n");
            chosen = Convert.ToInt32(Console.ReadLine());



            while (chosen < 1 || chosen > 2)
            {
                Console.Write("Invalid option.\n[1] Encrypt\n[2] Decrypt\n\n");
                chosen = Convert.ToInt32(Console.ReadLine());
            }
            
            if (chosen == 1 )
            {
                string key;
                
                Console.Write("Enter a key:\n");
                key = Console.ReadLine();

                while (!Regex.IsMatch(key, @"^\d+$"))
                {
                    Console.Write("Invalid number. Please re-enter:");
                    key = Console.ReadLine();
                }
            }

            switch (chosen)
            {
                case 1:
                    string num;

                    Console.Write("Enter a key:\n");
                    num = Console.ReadLine();

                    while (!Regex.IsMatch(num, @"^\d+$"))
                    {
                        Console.Write("Invalid number. Please re-enter:");
                        num = Console.ReadLine();
                    }

                    int key = int.Parse(num);

                    Console.WriteLine();

                    string phrase;

                    Console.Write("Enter a phrase you would like to encrypt:\n");
                    phrase = Console.ReadLine();

                    Encrypt(phrase, key);
                    break;

                default:
                    break;
            }

        }



        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
