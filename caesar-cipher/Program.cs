using System;
using System.Text.RegularExpressions;

namespace caesar_cipher
{
    class Program
    {

        static void Encrypt(string message, int key)
        {
            Console.WriteLine();

            foreach (var i in message)
            {
                int encrypted;
                encrypted = (int)i + key;

                char encrypted_letters = (Convert.ToChar(encrypted));
                string cipher_text = Convert.ToString(encrypted_letters);

                Console.Write(cipher_text);
            }

        }

        static void Decrypt(string cipher_text, int key)
        {
            Console.WriteLine();

            foreach (var i in cipher_text)
            {
                int decrypted;
                decrypted = (int)i - key;

                char decrypted_letters = (Convert.ToChar(decrypted));
                string decrypted_text = Convert.ToString(decrypted_letters);

                Console.Write(decrypted_text);
            }
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

            switch (chosen)
            {
                case 1:
                    Console.WriteLine();

                    string phrase;
                    Console.Write("Enter a phrase you would like to encrypt:\n");
                    phrase = Console.ReadLine();

                    Console.WriteLine();

                    string num;
                    Console.Write("Enter a key:\n");
                    num = Console.ReadLine();

                    while (!Regex.IsMatch(num, @"^\d+$"))
                    {
                        Console.Write("Invalid number. Please re-enter:");
                        num = Console.ReadLine();
                    }

                    int key = int.Parse(num);

                    Encrypt(phrase, key);
                    break;

                case 2:
                    Console.WriteLine();

                    string encrypted;
                    Console.Write("Enter a phrase you would like to decrypt:\n");
                    encrypted = Console.ReadLine();

                    Console.WriteLine();

                    string num2;
                    Console.Write("Enter a key:\n");
                    num2 = Console.ReadLine();

                    while (!Regex.IsMatch(num2, @"^\d+$"))
                    {
                        Console.Write("Invalid number. Please re-enter:");
                        num2 = Console.ReadLine();
                    }

                    int key2 = int.Parse(num2);

                    Decrypt(encrypted, key2);
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
