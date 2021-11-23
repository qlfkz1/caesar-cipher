using System;
using System.Threading;
using System.Text.RegularExpressions;

namespace caesar_cipher
{
    class Program
    {
        static void Encrypt(string message, int key)
        {
            Console.WriteLine();
            Console.Write("Encrypted output: ");

            foreach (var i in message)
            {
                int encrypted;
                encrypted = (int)i + key;

                if (encrypted > 127)
                {
                    encrypted = (encrypted - 94);
                }

                char encrypted_letters = (Convert.ToChar(encrypted));
                string cipher_text = Convert.ToString(encrypted_letters);

                Console.Write(cipher_text);
            }

            Thread.Sleep(5000);
            MainMenu();
        }

        static void Decrypt(string cipher_text, int key)
        {
            Console.WriteLine();
            Console.Write("Decrypted output: ");

            foreach (var i in cipher_text)
            {
                int decrypted;
                decrypted = (int)i - key;

                if (decrypted < 32)
                {
                    decrypted = (decrypted + 94);
                }

                char decrypted_letters = (Convert.ToChar(decrypted));
                string decrypted_text = Convert.ToString(decrypted_letters);

                Console.Write(decrypted_text);
            }

            Thread.Sleep(5000);
            MainMenu();
        }

        static void BruteForce(string cipher_text)
        {
            Console.WriteLine();

           for (int v = 1; v < 26; v++)
            {
                foreach (var i in cipher_text)
                {
                    int key;
                    key = (int)i - v;

                    if (key < 32)
                    {
                        key = (key + 94);
                    } else if (key > 127) {
                        key = (key - 94);
                    }

                    char bruteforced_letters = (Convert.ToChar(key));
                    string bruteforced_text = Convert.ToString(bruteforced_letters);

                    Console.Write(bruteforced_text);
                }
                Console.WriteLine();
            }

            Thread.Sleep(5000);
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            int chosen;

            Console.WriteLine("Caesar Cipher");
            Console.WriteLine();

            Console.Write("Would you like to:\n[1] Encrypt\n[2] Decrypt\n[3] Bruteforce\n\n");
            chosen = Convert.ToInt32(Console.ReadLine());

            while (chosen < 1 || chosen > 3)
            {
                Console.Write("Invalid option.\n[1] Encrypt\n[2] Decrypt\n[3] Bruteforce\n\n");
                chosen = Convert.ToInt32(Console.ReadLine());
            }

            switch (chosen)
            {
                case 1:
                    Console.WriteLine();

                    string phrase;
                    Console.Write("Enter a phrase you would like to encrypt:\n\n");
                    phrase = Console.ReadLine();

                    Console.WriteLine();

                    string num;
                    Console.Write("Enter a key:\n\n");
                    num = Console.ReadLine();

                    while (!Regex.IsMatch(num, @"^\d+$"))
                    {
                        Console.Write("Invalid number. Please re-enter:\n\n");
                        num = Console.ReadLine();
                    }

                    int key = int.Parse(num);

                    Encrypt(phrase, key);
                    break;
                case 2:
                    Console.WriteLine();

                    string encrypted;
                    Console.Write("Enter a phrase you would like to decrypt:\n\n");
                    encrypted = Console.ReadLine();

                    Console.WriteLine();

                    string num2;
                    Console.Write("Enter a key:\n");
                    num2 = Console.ReadLine();

                    while (!Regex.IsMatch(num2, @"^\d+$"))
                    {
                        Console.Write("Invalid number. Please re-enter:\n\n");
                        num2 = Console.ReadLine();
                    }

                    int key2 = int.Parse(num2);

                    Decrypt(encrypted, key2);
                    break;
                case 3:
                    Console.WriteLine();

                    string brutephrase;
                    Console.Write("Enter a phrase you would like to decrypt:\n\n");
                    brutephrase = Console.ReadLine();

                    Console.WriteLine();

                    BruteForce(brutephrase);
                    break;

                default:
                    Console.Write("\n Not an option. Error");
                    Thread.Sleep(4000);
                    MainMenu();
                    break;
            }

        }



        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
