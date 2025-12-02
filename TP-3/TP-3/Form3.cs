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
	internal partial class Form3 : Form
	{
		List<Joueur> joueurs = new List<Joueur>();

		public Form3(List<Joueur> joueurs)
		{
			InitializeComponent();

			this.joueurs = joueurs;

			label_j1.Text = joueurs[0].Identifiant;
			label_j2.Text = joueurs[1].Identifiant;

			panel_colj1.BackColor = joueurs[0].Couleur;
			panel_colj2.BackColor = joueurs[1].Couleur;
		}
	}
}
