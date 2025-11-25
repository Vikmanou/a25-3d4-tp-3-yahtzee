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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label2 = new Label();
			label3 = new Label();
			toolStrip1 = new ToolStrip();
			SuspendLayout();
			// 
			// textBox_identifiant
			// 
			textBox_identifiant.Location = new Point(108, 112);
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
			comboBox_couleur.Location = new Point(108, 154);
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
			// 
			// button1
			// 
			button1.Location = new Point(108, 204);
			button1.Name = "button1";
			button1.Size = new Size(109, 25);
			button1.TabIndex = 8;
			button1.Text = "Nouveau Joueur";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(287, 171);
			button2.Name = "button2";
			button2.Size = new Size(169, 25);
			button2.TabIndex = 9;
			button2.Text = "Modifier Joueur";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(287, 204);
			button3.Name = "button3";
			button3.Size = new Size(169, 25);
			button3.TabIndex = 10;
			button3.Text = "Supprimer Joueur";
			button3.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 115);
			label2.Name = "label2";
			label2.Size = new Size(67, 15);
			label2.TabIndex = 11;
			label2.Text = "Identifiant :";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 157);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 12;
			label3.Text = "Couleur :";
			// 
			// toolStrip1
			// 
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(483, 25);
			toolStrip1.TabIndex = 13;
			toolStrip1.Text = "toolStrip1";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(483, 253);
			Controls.Add(toolStrip1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(Sauvegarder);
			Controls.Add(listBox1);
			Controls.Add(comboBox_couleur);
			Controls.Add(label1);
			Controls.Add(textBox_identifiant);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox_identifiant;
        private Label label1;
        private ComboBox comboBox_couleur;
        private ListBox listBox1;
        private Button Sauvegarder;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private ToolStrip toolStrip1;
    }
}