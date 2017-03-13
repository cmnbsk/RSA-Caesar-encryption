using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace szyfr
{
    public partial class Form1 : Form
    {
        string pomoc = "Do działania programu niezbędna jest para kluczy (publiczny do zaszyfrowania i prywatny do odszyfrowania). Klucze można wygenerować za pomocą programu (przycisk Generuj klucze), albo skorzystać ze swoich. W tym celu należy przygotować klucze w formacie XML według tego generowanego przez program. Odpowiednie tagi oznaczają wymagane elementy które powinny znaleźć się w pliku XML.\nNiestety rozszyfrowanie jest możliwe tylko dla danych w postaci szesnastkowej.";
        RsaImpl rsaImpl;

        public Form1()
        {
            InitializeComponent();
            rsaImpl = new RsaImpl();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            boxUnencText.Text = szyfr.Cezar.decrypt(boxCipherText.Text);
        }
        
        private void encryptButton_Click(object sender, EventArgs e)
        {
            boxCipherText.Text = szyfr.Cezar.encrypt(boxUnencText.Text);
        }

        private void generateRSAkeys_Click(object sender, EventArgs e)
        {
            rsaImpl.rsaCSP = new RSACryptoServiceProvider();
            publicKeyBox.Text = rsaImpl.rsaCSP.ToXmlString(false);
            privateKeyBox.Text = rsaImpl.rsaCSP.ToXmlString(true);
        }

        private void rsaEncryptButton_Click(object sender, EventArgs e)
        {
            try {
                rsaImpl.rsaCSP.FromXmlString(publicKeyBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędny klucz publiczny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Zamiana na bity tekstu jawnego i wypisanie go w postaci szesnastkowego stringa
            byte[] bytes = rsaImpl.byteConverter.GetBytes(rsaPlainText.Text);
            string hex = BitConverter.ToString(bytes);
            rsaPlainTextBytes.Text = hex.Replace("-", "");

            //Wywołanie szyfrowania 
            rsaEncryptText.Text = rsaImpl.encryption(bytes);

            //Wypisanie tekstu zaszyfrowanego w postaci szesnastkowego stringa
            hex = BitConverter.ToString(rsaImpl.encryptedTextBytes);
            rsaEncryptedTextBytes.Text = hex.Replace("-", "");
        }

        private void rsaDecryptButton_Click(object sender, EventArgs e)
        {   
            try
            {
                rsaImpl.rsaCSP.FromXmlString(privateKeyBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędny klucz prywatny", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hex = rsaEncryptedTextBytes.Text;
            byte[] bytes = RsaImpl.StringToByteArray(hex);
            if(bytes != null)
                rsaDecryptText.Text = rsaImpl.decryption(bytes);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pomoc, "Pomoc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
