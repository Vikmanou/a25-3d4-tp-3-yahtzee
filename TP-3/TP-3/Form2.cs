using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
			if (listBox1.SelectedItem != null)
			{
				Joueur joueur = (Joueur)listBox1.SelectedItem;
				textBox_identifiant.Text = joueur.Identifiant;
				comboBox_couleur.SelectedItem = joueur.Couleur;

				modifieJoueur = true;
			}
		}

		private void retourALaccueilToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void exporterLesDonneesDuJoueurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null)
			{
				MessageBox.Show("Veuillez sélectionner un joueur à exporter.");
				return;
			}

			Joueur joueur = (Joueur)listBox1.SelectedItem;

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Fichier JSON | *.json | Tous les fichiers| *.* ";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.InitialDirectory = Application.StartupPath;
			saveFileDialog.FileName = "joueur_" + joueur.Identifiant + "_donnees.json";
			saveFileDialog.Title = "Exporter les données du joueur";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Dictionary<string, object> donneesJoueur = new Dictionary<string, object>
				{
					{ "ID", joueur.IdJoueur },
					{ "Identifiant", joueur.Identifiant },
					{ "Couleur", joueur.Couleur.ToString() },
					{ "PointsTotal", joueur.TotalPointsDesParties },
					{ "PartiesJouees", joueur.PartiesJouees }
				};

				var options = new JsonSerializerOptions
				{
					WriteIndented = true,
					Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
				};
				var jsonString = JsonSerializer.Serialize(donneesJoueur, options);
				File.WriteAllText(saveFileDialog.FileName, jsonString, System.Text.Encoding.UTF8);
			}
		}

		private void imprimerLesDonneesDuJoueurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
			printDocument1.DefaultPageSettings.Landscape = false;

			if (printDocument1.PrinterSettings.IsValid)
			{
				printDocument1.Print();
			}
			else
			{
				MessageBox.Show("L'imprimante spécifiée n'est pas valide.");
			}
		}
	}
}
