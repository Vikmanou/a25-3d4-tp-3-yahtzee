using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
	internal class Partie
	{
		const int NOMBRE_DE_ROULES_PAR_TOUR = 3;

		private int _nombreJoueurs;

		private List<int> _des;
		private List<bool> _desGardes;

		private List<Joueur> _joueurs;
		private int _tourJoueur = 0;
		private int _roulesRestants = NOMBRE_DE_ROULES_PAR_TOUR;

		public Partie(List<Joueur> joueurs)
		{
			_joueurs = joueurs;
			_nombreJoueurs = joueurs.Count;
			_des = new List<int> { 0, 0, 0, 0, 0 };
			_desGardes = new List<bool> { false, false, false, false, false };
		}

		public void LancerDes()
		{
			Random rand = new Random();
			for (int i = 0; i < _des.Count; i++)
			{
				if (!_desGardes[i])
				{
					_des[i] = rand.Next(1, 7);
				}
			}

			_roulesRestants--;
		}

		public void ProchainTour()
		{
			_tourJoueur = (_tourJoueur + 1) % _nombreJoueurs;
			_desGardes = new List<bool> { false, false, false, false, false };
			_roulesRestants = NOMBRE_DE_ROULES_PAR_TOUR;
		}

		public List<int> Des
		{
			get { return _des; }
		}

		public int RoulesRestants
		{
			get { return _roulesRestants; }
		}
	}
}
