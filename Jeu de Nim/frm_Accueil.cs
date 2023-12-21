using Jeu_de_Nim.Vue;

namespace Jeu_de_Nim
{
    public partial class frm_Accueil : Form
    {
        public frm_Accueil()
        {
            InitializeComponent();
        }


        private void button_Connexion_Click(object sender, EventArgs e)
        { 
            frm_Login frm_Login = new frm_Login();
            frm_Login.Show();
        }

        private void button_Inscription_Click(object sender, EventArgs e)
        {
            frm_Inscription frm_Inscription = new frm_Inscription();
            frm_Inscription.Show();
        }
    }
}
