namespace TP_3
{
	public partial class Form1 : Form
	{
		List<Joueur> joueurs = new List<Joueur>();

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button_creerJoueur_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(joueurs);
			if (form2.ShowDialog() == DialogResult.OK)
			{
				// TODO:
			}
		}
	}
}
