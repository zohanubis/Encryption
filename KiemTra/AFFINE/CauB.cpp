
#include<iostream>
using namespace std;


const int a = 5;
const int b = 8;

string encryptMessage(string msg)
{

	string cipher = "";
	for (int i = 0; i < msg.length(); i++)
	{

		if (msg[i] != ' ')

			cipher = cipher +
			(char)((((a * (msg[i] - 'A')) + b) % 26) + 'A');
		else

			cipher += msg[i];
	}
	return cipher;
}

string decryptCipher(string cipher)
{
	string msg = "";
	int a_inv = 0;
	int flag = 0;

	for (int i = 0; i < 26; i++)
	{
		flag = (a * i) % 26;


		if (flag == 1)
		{
			a_inv = i;
		}
	}
	for (int i = 0; i < cipher.length(); i++)
	{
		if (cipher[i] != ' ')

			msg = msg +
			(char)(((a_inv * ((cipher[i] + 'A' - b)) % 26)) + 'A');
		else
			msg += cipher[i];
	}

	return msg;
}

int main(void)
{
	string msg = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";


	string cipherText = encryptMessage(msg);
	cout << "Plaintext :" << msg << endl;
	cout << "Encrypted : " << cipherText << endl;
	cout << "Decrypted: " << decryptCipher(cipherText);

	return 0;
}
