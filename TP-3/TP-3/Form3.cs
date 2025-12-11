using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace TP_3
{
    internal partial class Form3 : Form
    {
        List<Joueur> joueurs = new List<Joueur>();
        Partie partie;

        List<PictureBox> listeDesDansZoneJeu;
        List<PictureBox> listeDesDansMain;

        bool melangerDes = false;
        Thread melangerThread;

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

                string couleurDeJoueur = joueurs[partie.TourJoueur].CouleurDes.Name;

                Image image = Properties.Resources.ResourceManager.GetObject($"De{couleurDeJoueur}_{valeurDe}") as Image;
                listeDesDansZoneJeu[i].BackgroundImage = image;
                listeDesDansMain[i].BackgroundImage = image;
            }

            int tourJoueur = partie.TourJoueur;
            label_tour.Text = $"Tour de : {joueurs[tourJoueur].Identifiant}";
        }

        private void animationMelanger()
        {
            while (melangerDes)
            {
                partie.MelangerDes();
                Invoke(new Action(mettreAJourDes));
                Thread.Sleep(100);
            }
        }

        private void button_lancer_Click(object sender, EventArgs e)
        {
            if (melangerThread == null || !melangerThread.IsAlive)
            {
                if (partie.LancesRestants == partie.LancesParTour)
                {
                    for (int i = 0; i < partie.DesDansMain.Count; i++)
                    {
                        partie.RelacherDe(i);
                    }
                }

                melangerDes = true;
                melangerThread = new Thread(animationMelanger);
                melangerThread.IsBackground = true;
                melangerThread.Start();

                button_lancer.Text = "ARRêTER";
            }
            else
            {
                melangerDes = false;

                partie.LancerDes();
                mettreAJourDes();

                button_lancer.Text = "LANCER";
            }

            if (partie.LancesRestants == 0)
            {
                button_lancer.Enabled = false;
            }
        }

        private void deJeu1_Click(object sender, EventArgs e)
        {
            partie.PrendreDeEnMain(0);
            mettreAJourDes();
        }

        private void deJeu2_Click(object sender, EventArgs e)
        {
            partie.PrendreDeEnMain(1);
            mettreAJourDes();
        }

        private void deJeu3_Click(object sender, EventArgs e)
        {
            partie.PrendreDeEnMain(2);
            mettreAJourDes();
        }

        private void deJeu4_Click(object sender, EventArgs e)
        {
            partie.PrendreDeEnMain(3);
            mettreAJourDes();
        }

        private void deJeu5_Click(object sender, EventArgs e)
        {
            partie.PrendreDeEnMain(4);
            mettreAJourDes();
        }

        private void deMain1_Click(object sender, EventArgs e)
        {
            partie.RelacherDe(0);
            mettreAJourDes();
        }

        private void deMain2_Click(object sender, EventArgs e)
        {
            partie.RelacherDe(1);
            mettreAJourDes();
        }

        private void deMain3_Click(object sender, EventArgs e)
        {
            partie.RelacherDe(2);
            mettreAJourDes();
        }

        private void deMain4_Click(object sender, EventArgs e)
        {
            partie.RelacherDe(3);
            mettreAJourDes();
        }

        private void deMain5_Click(object sender, EventArgs e)
        {
            partie.RelacherDe(4);
            mettreAJourDes();
        }

        private void calculerTotalEtAfficher()
        {
            int sommeNombresJoueur1 = 0;
            int sommeNombresJoueur2 = 0;

            foreach (Button bouton in new List<Button>() { button_uns1, button_deux1, button_trois1, button_quatres1, button_cinqs1, button_six1 })
            {
                if (int.TryParse(bouton.Text, out int score))
                {
                    sommeNombresJoueur1 += score;
                }
            }

            foreach (Button bouton in new List<Button>() { button_uns2, button_deux2, button_trois2, button_quatres2, button_cinqs2, button_six2 })
            {
                if (int.TryParse(bouton.Text, out int score))
                {
                    sommeNombresJoueur2 += score;
                }
            }

            label_somme1.Text = sommeNombresJoueur1.ToString();
            label_somme2.Text = sommeNombresJoueur2.ToString();

            label_bonus1.Text = (sommeNombresJoueur1 >= 63) ? "35" : "0";
            label_bonus2.Text = (sommeNombresJoueur2 >= 63) ? "35" : "0";

            List<Button> boutonsJoueur1 = new List<Button>()
            {
                button_threeOfAKind1, button_fourOfAKind1, button_fullHouse1, button_smallStraight1,
                button_largeStraight1, button_chance1, button_yahtzee1
            };

            List<Button> boutonsJoueur2 = new List<Button>()
            {
                button_threeOfAKind2, button_fourOfAKind2, button_fullHouse2, button_smallStraight2,
                button_largeStraight2, button_chance2, button_yahtzee2
            };

            int totalJoueur1 = sommeNombresJoueur1 + ((sommeNombresJoueur1 >= 63) ? 35 : 0);
            int totalJoueur2 = sommeNombresJoueur2 + ((sommeNombresJoueur2 >= 63) ? 35 : 0);

            foreach (Button bouton in boutonsJoueur1)
            {
                if (int.TryParse(bouton.Text, out int score))
                {
                    totalJoueur1 += score;
                }
            }

            foreach (Button bouton in boutonsJoueur2)
            {
                if (int.TryParse(bouton.Text, out int score))
                {
                    totalJoueur2 += score;
                }
            }

            label_total1.Text = totalJoueur1.ToString();
            label_total2.Text = totalJoueur2.ToString();
        }

        private void afficherScoreEtPasserAuProchainTour(Button bouton, Func<List<int>, int> calculerScore)
        {
            if (melangerDes)
            {
                MessageBox.Show("Veuillez arrêter le mélange des dés avant de soumettre votre score.");
                return;
            }

            if (bouton.Text == "-")
            {
                int tourJoueur = partie.TourJoueur + 1;
                if (bouton.Name.EndsWith(tourJoueur.ToString()) == false)
                {
                    MessageBox.Show("Ce n'est pas votre tour.");
                    return;
                }

                int score = calculerScore(partie.Des);

                bouton.Text = score.ToString();
                calculerTotalEtAfficher();

                if (partie.EstPartieTerminee())
                {
                    string messageFinPartie;
                    int totalJoueur1 = int.Parse(label_total1.Text);
                    int totalJoueur2 = int.Parse(label_total2.Text);

                    partie.PartieTerminee(totalJoueur1, totalJoueur2);

                    if (totalJoueur1 > totalJoueur2)
                    {
                        messageFinPartie = $"Le gagnant est {joueurs[0].Identifiant} avec {totalJoueur1} points.";
                    }
                    else if (totalJoueur2 > totalJoueur1)
                    {
                        messageFinPartie = $"Le gagnant est {joueurs[1].Identifiant} avec {totalJoueur2} points.";
                    }
                    else
                    {
                        messageFinPartie = "La partie est égale.";
                    }
                    MessageBox.Show(messageFinPartie);
                    this.Close();
                    return;
                }

                partie.ProchainTour();
                mettreAJourDes();

                button_lancer.Enabled = true;
            }
        }

        private void button_uns1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_uns1, CalculateurScore.Uns);
        }

        private void button_uns2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_uns2, CalculateurScore.Uns);
        }

        private void button_deux1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_deux1, CalculateurScore.Deux);
        }

        private void button_deux2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_deux2, CalculateurScore.Deux);
        }

        private void button_trois1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_trois1, CalculateurScore.Trois);
        }

        private void button_trois2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_trois2, CalculateurScore.Trois);
        }

        private void button_quatres1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_quatres1, CalculateurScore.Quatres);
        }

        private void button_quatres2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_quatres2, CalculateurScore.Quatres);
        }

        private void button_cinqs1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_cinqs1, CalculateurScore.Cinqs);
        }

        private void button_cinqs2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_cinqs2, CalculateurScore.Cinqs);
        }

        private void button_six1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_six1, CalculateurScore.Six);
        }

        private void button_six2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_six2, CalculateurScore.Six);
        }

        private void button_threeOfAKind1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_threeOfAKind1, CalculateurScore.ThreeOfAKind);
        }

        private void button_threeOfAKind2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_threeOfAKind2, CalculateurScore.ThreeOfAKind);
        }

        private void button_fourOfAKind1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_fourOfAKind1, CalculateurScore.FourOfAKind);
        }

        private void button_fourOfAKind2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_fourOfAKind2, CalculateurScore.FourOfAKind);
        }

        private void button_fullHouse1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_fullHouse1, CalculateurScore.FullHouse);
        }

        private void button_fullHouse2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_fullHouse2, CalculateurScore.FullHouse);
        }

        private void button_smallStraight1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_smallStraight1, CalculateurScore.SmallStraight);
        }

        private void button_smallStraight2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_smallStraight2, CalculateurScore.SmallStraight);
        }

        private void button_largeStraight1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_largeStraight1, CalculateurScore.LargeStraight);
        }

        private void button_largeStraight2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_largeStraight2, CalculateurScore.LargeStraight);
        }

        private void button_chance1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_chance1, CalculateurScore.Chance);
        }

        private void button_chance2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_chance2, CalculateurScore.Chance);
        }

        private void button_yahtzee1_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_yahtzee1, CalculateurScore.Yahtzee);
        }

        private void button_yahtzee2_Click(object sender, EventArgs e)
        {
            afficherScoreEtPasserAuProchainTour(button_yahtzee2, CalculateurScore.Yahtzee);
        }
    }
}
