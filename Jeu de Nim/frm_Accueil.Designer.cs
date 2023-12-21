namespace Jeu_de_Nim
{
    partial class frm_Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Connexion = new Button();
            button_Inscription = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_Connexion
            // 
            button_Connexion.Location = new Point(31, 109);
            button_Connexion.Name = "button_Connexion";
            button_Connexion.Size = new Size(169, 43);
            button_Connexion.TabIndex = 0;
            button_Connexion.Text = "Connexion";
            button_Connexion.UseVisualStyleBackColor = true;
            button_Connexion.Click += button_Connexion_Click;
            // 
            // button_Inscription
            // 
            button_Inscription.Location = new Point(31, 167);
            button_Inscription.Name = "button_Inscription";
            button_Inscription.Size = new Size(169, 43);
            button_Inscription.TabIndex = 1;
            button_Inscription.Text = "Inscription";
            button_Inscription.UseVisualStyleBackColor = true;
            button_Inscription.Click += button_Inscription_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 50);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Jeu du Nim";
            // 
            // frm_Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 246);
            Controls.Add(label1);
            Controls.Add(button_Inscription);
            Controls.Add(button_Connexion);
            Name = "frm_Accueil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Connexion;
        private Button button_Inscription;
        private Label label1;
    }
}
