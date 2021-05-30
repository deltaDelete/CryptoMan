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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Encrypt(object sender, EventArgs e)
        {
            CaesarCipher caesar = new CaesarCipher();
            result.Text = caesar.Encrypt(cryptText.Text, Convert.ToInt32(cryptNum.Text), cryptKey.Text);
        }

        private void Decrypt(object sender, EventArgs e)
        {
            CaesarCipher caesar = new CaesarCipher();
            result.Text = caesar.Decrypt(cryptText.Text, -Convert.ToInt32(cryptNum.Text), cryptKey.Text);
        }

        private void RUAlphabet(object sender, RoutedEventArgs e)
        {
            cryptKey.Text = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        }
        private void ENAlphabet(object sender, RoutedEventArgs e)
        {
            cryptKey.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
        private void RUENAlphabet(object sender, RoutedEventArgs e)
        {
            cryptKey.Text = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
    }
}
