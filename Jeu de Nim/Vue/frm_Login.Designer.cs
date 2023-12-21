namespace Jeu_de_Nim.Vue
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Connexion = new Label();
            label_Nom_Du_Joueur = new Label();
            label_MDP = new Label();
            textBox_Nom_Du_Joueur = new TextBox();
            textBox_MDP = new TextBox();
            button_Connexion = new Button();
            SuspendLayout();
            // 
            // label_Connexion
            // 
            label_Connexion.AutoSize = true;
            label_Connexion.Location = new Point(103, 36);
            label_Connexion.Name = "label_Connexion";
            label_Connexion.Size = new Size(65, 15);
            label_Connexion.TabIndex = 0;
            label_Connexion.Text = "Connexion";
            // 
            // label_Nom_Du_Joueur
            // 
            label_Nom_Du_Joueur.AutoSize = true;
            label_Nom_Du_Joueur.Location = new Point(26, 97);
            label_Nom_Du_Joueur.Name = "label_Nom_Du_Joueur";
            label_Nom_Du_Joueur.Size = new Size(94, 15);
            label_Nom_Du_Joueur.TabIndex = 1;
            label_Nom_Du_Joueur.Text = "Nom du joueur :";
            // 
            // label_MDP
            // 
            label_MDP.AutoSize = true;
            label_MDP.Location = new Point(37, 143);
            label_MDP.Name = "label_MDP";
            label_MDP.Size = new Size(83, 15);
            label_MDP.TabIndex = 2;
            label_MDP.Text = "Mot de passe :";
            // 
            // textBox_Nom_Du_Joueur
            // 
            textBox_Nom_Du_Joueur.Location = new Point(126, 94);
            textBox_Nom_Du_Joueur.Name = "textBox_Nom_Du_Joueur";
            textBox_Nom_Du_Joueur.Size = new Size(134, 23);
            textBox_Nom_Du_Joueur.TabIndex = 3;
            // 
            // textBox_MDP
            // 
            textBox_MDP.Location = new Point(126, 143);
            textBox_MDP.Name = "textBox_MDP";
            textBox_MDP.Size = new Size(134, 23);
            textBox_MDP.TabIndex = 4;
            // 
            // button_Connexion
            // 
            button_Connexion.Location = new Point(74, 203);
            button_Connexion.Name = "button_Connexion";
            button_Connexion.Size = new Size(125, 30);
            button_Connexion.TabIndex = 5;
            button_Connexion.Text = "Connexion";
            button_Connexion.UseVisualStyleBackColor = true;
            button_Connexion.Click += btnLogin_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(291, 273);
            Controls.Add(button_Connexion);
            Controls.Add(textBox_MDP);
            Controls.Add(textBox_Nom_Du_Joueur);
            Controls.Add(label_MDP);
            Controls.Add(label_Nom_Du_Joueur);
            Controls.Add(label_Connexion);
            Name = "frm_Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Connexion;
        private Label label_Nom_Du_Joueur;
        private Label label_MDP;
        private TextBox textBox_Nom_Du_Joueur;
        private TextBox textBox_MDP;
        private Button button_Connexion;
    }
}