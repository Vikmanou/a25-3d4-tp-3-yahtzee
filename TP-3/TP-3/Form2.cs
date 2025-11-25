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
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem is Joueur joueur)
			{
				textBox_identifiant.Text = joueur.Identifiant;
				comboBox_couleur.SelectedItem = joueur.Couleur;
			}
		}
	}
}
