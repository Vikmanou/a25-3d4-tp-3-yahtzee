namespace TP_3
{
    partial class Form1
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
			label1 = new Label();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			button2 = new Button();
			label2 = new Label();
			button_creerJoueur = new Button();
			checkedListBox_joueurs = new CheckedListBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F);
			label1.Location = new Point(60, 18);
			label1.Name = "label1";
			label1.Size = new Size(87, 30);
			label1.TabIndex = 2;
			label1.Text = "Yahtzee";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(23, 51);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(164, 149);
			pictureBox1.TabIndex = 3;
			pictureBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new Point(36, 226);
			button1.Name = "button1";
			button1.Size = new Size(138, 34);
			button1.TabIndex = 4;
			button1.Text = "Demarrer une partie";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(369, 245);
			button2.Name = "button2";
			button2.Size = new Size(85, 25);
			button2.TabIndex = 5;
			button2.Text = "Quitter";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(267, 27);
			label2.Name = "label2";
			label2.Size = new Size(64, 21);
			label2.TabIndex = 7;
			label2.Text = "Joueurs";
			// 
			// button_creerJoueur
			// 
			button_creerJoueur.Location = new Point(267, 179);
			button_creerJoueur.Name = "button_creerJoueur";
			button_creerJoueur.Size = new Size(124, 26);
			button_creerJoueur.TabIndex = 8;
			button_creerJoueur.Text = "Creer un joueur";
			button_creerJoueur.UseVisualStyleBackColor = true;
			button_creerJoueur.Click += button_creerJoueur_Click;
			// 
			// checkedListBox_joueurs
			// 
			checkedListBox_joueurs.FormattingEnabled = true;
			checkedListBox_joueurs.Location = new Point(267, 61);
			checkedListBox_joueurs.Name = "checkedListBox_joueurs";
			checkedListBox_joueurs.Size = new Size(139, 112);
			checkedListBox_joueurs.TabIndex = 9;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(480, 282);
			Controls.Add(checkedListBox_joueurs);
			Controls.Add(button_creerJoueur);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button_creerJoueur;
		private CheckedListBox checkedListBox_joueurs;
	}
}
