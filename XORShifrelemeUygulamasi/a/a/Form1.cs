using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XORShifrelemeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private string Encrypt(string plainText, string key)
        {
            StringBuilder encryptedText = new StringBuilder();

            for (int i = 0; i < plainText.Length; i++)
            {
                encryptedText.Append((char)(plainText[i] ^ key[i % key.Length]));
            }

            return encryptedText.ToString();
        }

        private string Decrypt(string encryptedText, string key)
        {
            // Şifreleme ve çözme işlemleri XOR işlemi ile aynı olduğu için aynı metodu kullanabiliriz.
            return Encrypt(encryptedText, key);
        }

        private void buttonSifrele_Click(object sender, EventArgs e)
        {
            string plainText = richTextBoxMetin.Text;
            string key = richTextBoxAnahtar.Text;

            string encryptedText = Encrypt(plainText, key);
            richTextBoxSifrelimetin.Text = encryptedText;
        }

        private void buttonCoz_Click(object sender, EventArgs e)
        {
            string encryptedText = richTextBoxSifrelimetin.Text;
            string key = richTextBoxAnahtar.Text;

            string decryptedText = Decrypt(encryptedText, key);
            richTextBoxCozulmusMetin.Text = decryptedText;
        }
    }
}
