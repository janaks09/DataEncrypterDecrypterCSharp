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

namespace DataEncrypterDecrypter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void encryptbtn_Click(object sender, RoutedEventArgs e)
        {
            if(plaintext.Text!= string.Empty)
            {
                //Here key is of 128 bit
                //Key should be either of 128 bit or of 192 bit
                Ciphertext.Text = CryptoEngine.Encrypt(plaintext.Text, "sblw-3hn8-sqoy19");
            }
        }

        private void decryptbtn_Click(object sender, RoutedEventArgs e)
        {
            if(Ciphertext.Text != string.Empty)
            {
                //Key shpuld be same for encryption and decryption
                decryptedtext.Text = CryptoEngine.Decrypt(Ciphertext.Text, "sblw-3hn8-sqoy19");
            }
        }
    }
}
