using CryptoMan.Code;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        // менюшки
        private void RUAlphabet(object sender, RoutedEventArgs e)
        {
            cryptAlphabet.Text = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        }
        private void ENAlphabet(object sender, RoutedEventArgs e)
        {
            cryptAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        private void RUENAlphabet(object sender, RoutedEventArgs e)
        {
            cryptAlphabet.Text = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        private void Encrypt(object sender, EventArgs e)
        {
            var vigenere = new VigenereCipher(cryptAlphabet.Text.ToUpper());
            result.Text = vigenere.Decrypt(cryptText.Text.ToUpper(), cryptKey.Text.ToUpper());
        }

        // кнопочки
        private void Decrypt(object sender, EventArgs e)
        {
            var vigenere = new VigenereCipher(cryptAlphabet.Text.ToUpper());
            result.Text = vigenere.Encrypt(cryptText.Text.ToUpper(), cryptKey.Text.ToUpper());
        }
    }
}
