namespace TP_3
{
	public partial class Form1 : Form
	{
		List<Joueur> joueurs = new List<Joueur>();

		public Form1()
		{
			InitializeComponent();
			checkedListBox_joueurs.Items.Clear();
			validerSi2JouersSelectionnes();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button_creerJoueur_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(joueurs);
			form2.ShowDialog();

			foreach (Joueur joueur in joueurs)
			{
				if (!checkedListBox_joueurs.Items.Contains(joueur))
				{
					checkedListBox_joueurs.Items.Add(joueur);
				}
			}
		}

		private void validerSi2JouersSelectionnes()
		{
			if (checkedListBox_joueurs.CheckedItems.Count >= 2)
			{
				button_demarrer.Enabled = true;
			}
			else
			{
				button_demarrer.Enabled = false;
			}
		}

		private void checkedListBox_joueurs_SelectedIndexChanged(object sender, EventArgs e) { validerSi2JouersSelectionnes(); }

		private void button_demarrer_Click(object sender, EventArgs e)
		{

		}
	}
}
