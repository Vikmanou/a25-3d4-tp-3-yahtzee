using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
	internal class Joueur
	{
		private static int compteurJoueurs = 0;

		private string _identifiant;
		private Color _couleur;
		private Color _couleurDes;
		private int _idJoueur;

		private int _points;
		private int _partiesJouees;
		private int _totalPointsDesParties;

		public Joueur(string identifiant, Color couleur, Color couleurDes)
		{
			_identifiant = identifiant;
			_couleur = couleur;
			_couleurDes = couleurDes;
			_idJoueur = compteurJoueurs;
			compteurJoueurs++;
			_points = 0;
			_partiesJouees = 0;
			_totalPointsDesParties = 0;
		}

		public void PartieTerminee(int points)
		{
            _points += points;
            _totalPointsDesParties += points;
            _partiesJouees++;
			_points = 0;
		}

		public string Identifiant
		{
			get { return _identifiant; }
		}

		public Color Couleur
		{
			get { return _couleur; }
		}

		public int Points
		{
			get { return _points; }
		}

		public int TotalPointsDesParties
		{
			get { return _totalPointsDesParties; }
		}

		public int PartiesJouees
		{
			get { return _partiesJouees; }
		}

		public int IdJoueur
		{
			get { return _idJoueur; }
		}

		public Color CouleurDes
		{
			get { return _couleurDes; }
		}

		public override string ToString()
		{
			return _identifiant;
		}
	}
}
