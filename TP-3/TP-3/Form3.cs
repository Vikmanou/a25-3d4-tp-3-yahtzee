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
        Partie partie;

        List<PictureBox> listeDesDansZoneJeu;
        List<PictureBox> listeDesDansMain;

        public Form3(List<Joueur> joueurs)
        {
            InitializeComponent();

            this.joueurs = joueurs;

            label_j1.Text = joueurs[0].Identifiant;
            label_j2.Text = joueurs[1].Identifiant;

            panel_colj1.BackColor = joueurs[0].Couleur;
            panel_colj2.BackColor = joueurs[1].Couleur;

            partie = new Partie(joueurs);

            listeDesDansZoneJeu = new List<PictureBox>() { deJeu1, deJeu2, deJeu3, deJeu4, deJeu5 };
            listeDesDansMain = new List<PictureBox>() { deMain1, deMain2, deMain3, deMain4, deMain5 };

            mettreAJourDes();
        }

        private void mettreAJourDes()
        {
            for (int i = 0; i < partie.Des.Count; i++)
            {
                int valeurDe = partie.Des[i];

                bool estDeDansMain = partie.DesDansMain[i];

                if (estDeDansMain)
                {
                    listeDesDansMain[i].Visible = true;
                    listeDesDansZoneJeu[i].Visible = false;
                }
                else
                {
                    listeDesDansMain[i].Visible = false;
                    listeDesDansZoneJeu[i].Visible = true;
                }
            }
        }

        private void button_lancer_Click(object sender, EventArgs e)
        {
            partie.LancerDes();
            mettreAJourDes();
        }
    }
}
