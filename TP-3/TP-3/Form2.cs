using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_3
{
	internal partial class Form2 : Form
	{
		List<Joueur> joueurs = new List<Joueur>();
		List<Color> couleurs = new List<Color> { Color.Red, Color.Blue, Color.Green, Color.Yellow };

		private bool modifieJoueur = false;

		public Form2(List<Joueur> joueurs)
		{
			InitializeComponent();

			this.joueurs = joueurs;

			listBox1.Items.Clear();
			foreach (Joueur joueur in joueurs)
			{
				listBox1.Items.Add(joueur);
			}

			comboBox_couleur.Items.Clear();
			foreach (Color couleur in couleurs)
			{
				comboBox_couleur.Items.Add(couleur);
			}

			listBox1_SelectedIndexChanged(null, null);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null)
			{
				button3.Enabled = true;
				button_modifJoueur.Enabled = true;
			}
			else
			{
				button3.Enabled = false;
				button_modifJoueur.Enabled = false;
				modifieJoueur = false;
			}
		}

		private void button_nouvJoueur_Click(object sender, EventArgs e)
		{
			comboBox_couleur.SelectedItem = null;
			textBox_identifiant.Clear();
		}

		private void Sauvegarder_Click(object sender, EventArgs e)
		{
			if (comboBox_couleur.SelectedItem == null)
			{
				MessageBox.Show("Veuillez sélectionner une couleur.");
				return;
			}

			for (int i = 0; i < joueurs.Count; i++)
			{
				Joueur ceJoueur = joueurs[i];
				if (ceJoueur.Identifiant == textBox_identifiant.Text && ceJoueur != listBox1.SelectedItem)
				{
					MessageBox.Show("Un joueur avec cet identifiant existe déjà.");
					return;
				}
			}

			if (listBox1.SelectedItem != null && modifieJoueur)
			{
				Joueur joueurAEnlever = (Joueur)listBox1.SelectedItem;
				joueurs.Remove(joueurAEnlever);
				listBox1.Items.Remove(joueurAEnlever);
			}

			Joueur joueur = new Joueur(textBox_identifiant.Text, (Color)comboBox_couleur.SelectedItem);

			joueurs.Add(joueur);
			listBox1.Items.Add(joueur);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null)
			{
				Joueur joueur = (Joueur)listBox1.SelectedItem;
				joueurs.Remove(joueur);
				listBox1.Items.Remove(joueur);
			}
			else
			{
				MessageBox.Show("Veuillez sélectionner un joueur à supprimer.");
			}
		}

		private void button_modifJoueur_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem != null) {
				Joueur joueur = (Joueur)listBox1.SelectedItem;
				textBox_identifiant.Text = joueur.Identifiant;
				comboBox_couleur.SelectedItem = joueur.Couleur;

				modifieJoueur = true;
			}
		}
	}
}
