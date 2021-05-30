using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMan.Code
{
    public class Atbash
    {
        //алфавит языка
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        //метод для переворачивания строки
        private string Reverse(string inputText)
        {
            //переменная для хранения результата
            var reversedText = string.Empty;
            foreach (var s in inputText)
            {
                //добавляем символ в начало строки
                reversedText = s + reversedText;
            }

            return reversedText;
        }

        //метод шифрования/дешифрования
        private string EncryptDecrypt(string text, string symbols, string cipher)
        {
            //переводим текст в нижний регистр
            text = text.ToLower();

            var outputText = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                //поиск позиции символа в строке алфавита
                var index = symbols.IndexOf(text[i]);
                if (index >= 0)
                {
                    //замена символа на шифр
                    outputText += cipher[index].ToString();
                }
            }

            return outputText;
        }

        //шифрование текста
        public string EncryptText(string plainText, string letters = alphabet)
        {
            return EncryptDecrypt(plainText, letters, Reverse(letters));
        }

        //расшифровка текста
        public string DecryptText(string encryptedText, string letters = alphabet)
        {
            return EncryptDecrypt(encryptedText, Reverse(letters), letters);
        }
    }
}
