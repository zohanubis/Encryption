using System;

namespace Cryptography_Algorithms
{
    class CaesarCipher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to Encrypt or Decrypt?\n1. Encrypt\n2. Decrypt\n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter message to encrypt: ");
                    string encryptMessage = Console.ReadLine();

                    Console.WriteLine("Enter encryption key: ");
                    int encryptKey = Convert.ToInt32(Console.ReadLine());

                    encryptMessage = encryptMessage.ToLower();

                    string encryptedMessage = Encrypt(encryptMessage.ToCharArray(), encryptKey);

                    Console.WriteLine("\nEncrypted message: " + encryptedMessage);
                    break;

                case 2:
                    Console.WriteLine("\nEnter message to decrypt: ");
                    string decryptMessage = Console.ReadLine();

                    Console.WriteLine("Enter decryption key: ");
                    int decryptKey = Convert.ToInt32(Console.ReadLine());

                    decryptMessage = decryptMessage.ToLower();

                    string decryptedMessage = Decrypt(decryptMessage.ToCharArray(), decryptKey);

                    Console.WriteLine("\nDecrypted message: " + decryptedMessage);
                    break;

                default:
                    Console.WriteLine("Enter a valid value.");
                    break;

            }

            Console.ReadLine();
        }

        static string Encrypt(char[] secretMessage, int key)
        {
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                if(secretMessage[i] == ' ')
                {
                    encryptedMessage[i] = ' ';
                    i++;
                }

                encryptedMessage[i] = Alphabet.alphabet[(key + Array.IndexOf(Alphabet.alphabet, secretMessage[i])) % 26];
            }

            return new string(encryptedMessage);
        }

        static string Decrypt(char[] secretMessage, int key)
        {
            char[] decryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                if (secretMessage[i] == ' ')
                {
                    decryptedMessage[i] = ' ';
                    i++;
                }

                decryptedMessage[i] = Alphabet.alphabet[(key + Array.IndexOf(Alphabet.alphabet, secretMessage[i])) % 26];
            }

            return new string(decryptedMessage);
        }
    }

    static class Alphabet
    {
        public static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    }
}
