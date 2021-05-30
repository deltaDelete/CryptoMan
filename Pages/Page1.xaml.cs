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
        public Page1()
        {
            InitializeComponent();
        }

        private void Encrypt(object sender, EventArgs e)
        {
            string text = cryptText.Text;
            string key = cryptKey.Text;

            string encryptedText = AES.Encryption.encryptData(text, key);

            result.Text = encryptedText;
        }
        private void Decrypt(object sender, EventArgs e)
        {
            string text = cryptText.Text;
            string key = cryptKey.Text;

            string encryptedText = text;

            string decryptedText = AES.Encryption.decryptData(encryptedText, key);

            result.Text = decryptedText;

        }
        private void GenKey(object sender, EventArgs e)
        {
            string randomKey = CryptoMan.Code.RandomHEX.GetRandomHexNumber(64);
            randomKey = randomKey.Replace("0", "1");
            cryptKey.Text = randomKey;
        }
        private void ReturnToStandard(object sender, EventArgs e)
        {
            string standardvalue = "65169BA703721149C9997CC111AD1D6ACDCD7D45A6232049594EB20827C93229";
            cryptKey.Text = standardvalue;
        }
    }
}