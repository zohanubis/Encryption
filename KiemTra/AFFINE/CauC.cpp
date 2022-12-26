#include <iostream>
using namespace std;

// Key values of a and b
const int a = 5;
const int b = 8;

string encryptMessage(string plainText)
{
    string cipher = "";

    for (int i = 0; i < plainText.length(); i++)
    {
        if (plainText[i] != ' ')
        {
            if ((plainText[i] >= 'a' && plainText[i] <= 'z') || (plainText[i] >= 'A' && plainText[i] <= 'Z'))
            {
                if (plainText[i] >= 'a' && plainText[i] <= 'z')
                {
                    cipher = cipher + (char)((((a * (plainText[i] - 'a')) + b) % 26) + 'a');
                }

                else if (plainText[i] >= 'A' && plainText[i] <= 'Z')
                {
                    cipher = cipher + (char)((((a * (plainText[i] - 'A')) + b) % 26) + 'A');
                }
            }
            else
            {
                cipher += plainText[i];
            }
        }
        else
        {
            cipher += plainText[i];
        }
    }
    return cipher;
}

string decryptCipher(string cipher)
{
    string plainText = "";
    int aInverse = 0;
    int flag = 0;

    for (int i = 0; i < 26; i++)
    {
        flag = (a * i) % 26;

        if (flag == 1)
        {
            aInverse = i;
        }
    }

    for (int i = 0; i < cipher.length(); i++)
    {
        if ((cipher[i] >= 'a' && cipher[i] <= 'z') || (cipher[i] >= 'A' && cipher[i] <= 'Z'))
        {
            int offset = ((cipher[i] - 'A') / 26) ? a - 1 : 0;
            if (cipher[i] >= 'a' && cipher[i] <= 'z')
            {
                plainText = plainText + (char)(((aInverse * (cipher[i] + 'a' - b) - offset) % 26) + 'a');
            }
            else if (cipher[i] >= 'A' && cipher[i] <= 'Z')
            {
                plainText = plainText + (char)(((aInverse * (cipher[i] + 'A' - b) - offset) % 26) + 'A');
            }
        }
    }

    return plainText;
}

// Driver Program
int main(void)
{
    string msg = "ThE QuiCK bROWN FOX jumps OvER THE lazy DOG";

    string cipherText = encryptMessage(msg);

    cout << "Plaintext: " << msg << endl;
    cout << "Ciphertext: " << cipherText << endl;

    return 0;
}