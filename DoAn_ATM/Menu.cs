namespace DoAn_ATM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_PlayFair_Click(object sender, EventArgs e)
        {
            PlayFair pf = new PlayFair();
            pf.Show();
        }

        private void bt_RSA_Click(object sender, EventArgs e)
        {
            RSA_Encryption rsa = new RSA_Encryption();
            rsa.Show();
        }
    }
}
