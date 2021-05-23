using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptoMan.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        private int BlockSize = 128;

        public Page1()
        {
            InitializeComponent();
        }

        /*
        private void Encrypt(object sender, EventArgs e)
            {
            if (cryptKey.Text == "") return;
            byte[] bytes = Encoding.Unicode.GetBytes(cryptText.Text);
            //Encrypt
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.BlockSize = BlockSize;
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(cryptKey.Text));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(bytes, 0, bytes.Length);
                }

                result.Text = Convert.ToBase64String(memoryStream.ToArray());
            }
        }

        private void Decrypt(object sender, RoutedEventArgs e)
        {
            if (cryptKey.Text == "") return;
            //Decrypt
            byte[] bytes = Convert.FromBase64String(result.Text);
            SymmetricAlgorithm crypt = Aes.Create();
            HashAlgorithm hash = MD5.Create();
            crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(result.Text));
            crypt.IV = IV;

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                using (CryptoStream cryptoStream =
                   new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[bytes.Length];
                    cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                    cryptText.Text = Encoding.Unicode.GetString(decryptedBytes);
                }
            }
        }
        */

        private void Encrypt(object sender, EventArgs e)
        {
            string text = "  Hello World  ";
            string key = "44 52 d7 16 87 b6 bc 2c 93 89 c3 34 9f dc 17 fb 3d fb ba 62 24 af fb 76 76 e1 33 79 26 cd d6 02";

            string encryptedText = AES.Encryption.encryptData(text, key);

            result.Text = encryptedText;
        }
        private void Decrypt(object sender, EventArgs e)
        {
            string text = "  Hello World  ";
            string key = "44 52 d7 16 87 b6 bc 2c 93 89 c3 34 9f dc 17 fb 3d fb ba 62 24 af fb 76 76 e1 33 79 26 cd d6 02";

            string encryptedText= result.Text;

            string decryptedText = AES.Encryption.decryptData(encryptedText, key);

            cryptText.Text = decryptedText;

        }
    }
}