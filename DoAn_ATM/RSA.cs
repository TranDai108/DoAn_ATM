using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_ATM
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }

        private void bt_RSA_Encrypt_Click(object sender, EventArgs e)
        {
            RSA_Encryption encrypt_RSA = new RSA_Encryption();
            encrypt_RSA.Show();
        }

        private void bt_RSA_Decrypt_Click(object sender, EventArgs e)
        {
            RSA_Decryption decrypt_RSA = new RSA_Decryption();
            decrypt_RSA.Show();
        }
    }
}
