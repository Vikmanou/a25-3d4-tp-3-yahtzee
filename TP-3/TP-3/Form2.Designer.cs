namespace TP_3
{
    partial class Form2
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
			textBox_identifiant = new TextBox();
			label1 = new Label();
			comboBox_couleur = new ComboBox();
			listBox1 = new ListBox();
			Sauvegarder = new Button();
			button_nouvJoueur = new Button();
			button_modifJoueur = new Button();
			button3 = new Button();
			label2 = new Label();
			label3 = new Label();
			menuStrip1 = new MenuStrip();
			fichierToolStripMenuItem = new ToolStripMenuItem();
			exporterLesDonneesDuJoueurToolStripMenuItem = new ToolStripMenuItem();
			imprimerLesDonneesDesJoueurToolStripMenuItem = new ToolStripMenuItem();
			retourALaccueilToolStripMenuItem = new ToolStripSeparator();
			retourALaccueilToolStripMenuItem1 = new ToolStripMenuItem();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			label4 = new Label();
			comboBox_colDe = new ComboBox();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// textBox_identifiant
			// 
			textBox_identifiant.Location = new Point(117, 112);
			textBox_identifiant.Name = "textBox_identifiant";
			textBox_identifiant.Size = new Size(100, 23);
			textBox_identifiant.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16F);
			label1.Location = new Point(21, 42);
			label1.Name = "label1";
			label1.Size = new Size(87, 30);
			label1.TabIndex = 3;
			label1.Text = "Yahtzee";
			// 
			// comboBox_couleur
			// 
			comboBox_couleur.FormattingEnabled = true;
			comboBox_couleur.Location = new Point(117, 142);
			comboBox_couleur.Name = "comboBox_couleur";
			comboBox_couleur.Size = new Size(100, 23);
			comboBox_couleur.TabIndex = 5;
			// 
			// listBox1
			// 
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 15;
			listBox1.Location = new Point(287, 56);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(169, 109);
			listBox1.TabIndex = 6;
			listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
			// 
			// Sauvegarder
			// 
			Sauvegarder.Location = new Point(11, 204);
			Sauvegarder.Name = "Sauvegarder";
			Sauvegarder.Size = new Size(85, 25);
			Sauvegarder.TabIndex = 7;
			Sauvegarder.Text = "Sauvegarder";
			Sauvegarder.UseVisualStyleBackColor = true;
			Sauvegarder.Click += Sauvegarder_Click;
			// 
			// button_nouvJoueur
			// 
			button_nouvJoueur.Location = new Point(108, 204);
			button_nouvJoueur.Name = "button_nouvJoueur";
			button_nouvJoueur.Size = new Size(109, 25);
			button_nouvJoueur.TabIndex = 8;
			button_nouvJoueur.Text = "Nouveau Joueur";
			button_nouvJoueur.UseVisualStyleBackColor = true;
			button_nouvJoueur.Click += button_nouvJoueur_Click;
			// 
			// button_modifJoueur
			// 
			button_modifJoueur.Location = new Point(287, 171);
			button_modifJoueur.Name = "button_modifJoueur";
			button_modifJoueur.Size = new Size(169, 25);
			button_modifJoueur.TabIndex = 9;
			button_modifJoueur.Text = "Modifier Joueur";
			button_modifJoueur.UseVisualStyleBackColor = true;
			button_modifJoueur.Click += button_modifJoueur_Click;
			// 
			// button3
			// 
			button3.Location = new Point(287, 204);
			button3.Name = "button3";
			button3.Size = new Size(169, 25);
			button3.TabIndex = 10;
			button3.Text = "Supprimer Joueur";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 115);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 11;
			label2.Text = "Identifiant :";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 144);
			label3.Name = "label3";
			label3.Size = new Size(92, 15);
			label3.TabIndex = 12;
			label3.Text = "Couleur Avatar :";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(483, 24);
			menuStrip1.TabIndex = 14;
			menuStrip1.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exporterLesDonneesDuJoueurToolStripMenuItem, imprimerLesDonneesDesJoueurToolStripMenuItem, retourALaccueilToolStripMenuItem, retourALaccueilToolStripMenuItem1 });
			fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			fichierToolStripMenuItem.Size = new Size(54, 20);
			fichierToolStripMenuItem.Text = "&Fichier";
			// 
			// exporterLesDonneesDuJoueurToolStripMenuItem
			// 
			exporterLesDonneesDuJoueurToolStripMenuItem.Name = "exporterLesDonneesDuJoueurToolStripMenuItem";
			exporterLesDonneesDuJoueurToolStripMenuItem.Size = new Size(246, 22);
			exporterLesDonneesDuJoueurToolStripMenuItem.Text = "Exporter les donnees du joueur";
			exporterLesDonneesDuJoueurToolStripMenuItem.Click += exporterLesDonneesDuJoueurToolStripMenuItem_Click;
			// 
			// imprimerLesDonneesDesJoueurToolStripMenuItem
			// 
			imprimerLesDonneesDesJoueurToolStripMenuItem.Name = "imprimerLesDonneesDesJoueurToolStripMenuItem";
			imprimerLesDonneesDesJoueurToolStripMenuItem.Size = new Size(246, 22);
			imprimerLesDonneesDesJoueurToolStripMenuItem.Text = "Imprimer les donnees des joueur";
			imprimerLesDonneesDesJoueurToolStripMenuItem.Click += imprimerLesDonneesDuJoueurToolStripMenuItem_Click;
			// 
			// retourALaccueilToolStripMenuItem
			// 
			retourALaccueilToolStripMenuItem.Name = "retourALaccueilToolStripMenuItem";
			retourALaccueilToolStripMenuItem.Size = new Size(243, 6);
			// 
			// retourALaccueilToolStripMenuItem1
			// 
			retourALaccueilToolStripMenuItem1.Name = "retourALaccueilToolStripMenuItem1";
			retourALaccueilToolStripMenuItem1.Size = new Size(246, 22);
			retourALaccueilToolStripMenuItem1.Text = "Retour a l'accueil";
			retourALaccueilToolStripMenuItem1.Click += retourALaccueilToolStripMenuItem1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(20, 171);
			label4.Name = "label4";
			label4.Size = new Size(77, 15);
			label4.TabIndex = 16;
			label4.Text = "Couleur Dés :";
			label4.TextAlign = ContentAlignment.MiddleLeft;
			label4.Click += label4_Click;
			// 
			// comboBox_colDe
			// 
			comboBox_colDe.FormattingEnabled = true;
			comboBox_colDe.Location = new Point(116, 169);
			comboBox_colDe.Name = "comboBox_colDe";
			comboBox_colDe.Size = new Size(100, 23);
			comboBox_colDe.TabIndex = 15;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(483, 253);
			Controls.Add(label4);
			Controls.Add(comboBox_colDe);
			Controls.Add(menuStrip1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button3);
			Controls.Add(button_modifJoueur);
			Controls.Add(button_nouvJoueur);
			Controls.Add(Sauvegarder);
			Controls.Add(listBox1);
			Controls.Add(comboBox_couleur);
			Controls.Add(label1);
			Controls.Add(textBox_identifiant);
			MainMenuStrip = menuStrip1;
			Name = "Form2";
			Text = "Form2";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox_identifiant;
        private Label label1;
        private ComboBox comboBox_couleur;
        private ListBox listBox1;
        private Button Sauvegarder;
        private Button button_nouvJoueur;
        private Button button_modifJoueur;
        private Button button3;
        private Label label2;
        private Label label3;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fichierToolStripMenuItem;
		private ToolStripMenuItem exporterLesDonneesDuJoueurToolStripMenuItem;
		private ToolStripMenuItem imprimerLesDonneesDesJoueurToolStripMenuItem;
		private ToolStripSeparator retourALaccueilToolStripMenuItem;
		private ToolStripMenuItem retourALaccueilToolStripMenuItem1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private Label label4;
		private ComboBox comboBox_colDe;
	}
}