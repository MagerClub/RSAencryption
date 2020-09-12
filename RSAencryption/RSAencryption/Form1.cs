using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RSAencryption
{

    public partial class Form1 : Form
    {

        public class RSAenc
        {
            private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
            RSAParameters privatekey;
            RSAParameters publickey;

            public RSAenc()
            {
                privatekey = csp.ExportParameters(true);
                publickey = csp.ExportParameters(false);
            }

            public string publickeyString()
            {
                var sw = new StringWriter();
                var xs = new XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, publickey);
                return sw.ToString();
            }

            public string encrypt(string plaintext)
            {
                csp = new RSACryptoServiceProvider();
                csp.ImportParameters(publickey);
                var data = Encoding.Unicode.GetBytes(plaintext);
                var cyper = csp.Encrypt(data, false);
                return Convert.ToBase64String(cyper);
            }

            public string decrypt(string cypertext)
            {
                var databytes = Convert.FromBase64String(cypertext);
                csp.ImportParameters(privatekey);
                var plaintext = csp.Decrypt(databytes, false);
                return Encoding.Unicode.GetString(plaintext);
            }
        }

        RSAenc rs = new RSAenc();

        public Form1()
        {
            InitializeComponent();
            RSAenc rs = new RSAenc();
        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            string cypher = string.Empty;
            if (txt_encrypt.Text != "")
            {
                cypher = rs.encrypt(txt_encrypt.Text);
                txt_encrypted.Text = cypher;
            }
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var plaintext = rs.decrypt(txt_encrypted.Text);
                txt_decrypted.Text = plaintext;
            } catch (Exception)
            {
                Console.WriteLine("teks enkripsi tidak valid");
            }
            
        }
    }
}
