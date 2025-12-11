using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
	internal class Partie
	{
		const int NOMBRE_DE_LANCES_PAR_TOUR = 3;

		private int _nombreJoueurs;

		private List<int> _des;
		private List<bool> _desDansMain;

		private List<Joueur> _joueurs;
		private int _tourJoueur = 0;
		private int _lancesRestants = NOMBRE_DE_LANCES_PAR_TOUR;

        Random rand = new Random();

        public Partie(List<Joueur> joueurs)
		{
			_joueurs = joueurs;
			_nombreJoueurs = joueurs.Count;
			_des = new List<int> { 0, 0, 0, 0, 0 };
            _desDansMain = new List<bool> { true, true, true, true, true };
		}

		public void LancerDes()
		{
			if (_lancesRestants <= 0)
			{
				throw new Exception("Aucun lance restant pour ce tour.");
			}

			if (_lancesRestants == NOMBRE_DE_LANCES_PAR_TOUR)
			{
				for (int i = 0; i < _desDansMain.Count; i++)
				{
					_desDansMain[i] = false;
				}
			}

			MelangerDes();

            _lancesRestants--;
		}

		public void MelangerDes()
		{
            for (int i = 0; i < _des.Count; i++)
            {
                if (!_desDansMain[i])
                {
                    _des[i] = rand.Next(1, 7);
                }
            }
        }

		public void PrendreDeEnMain(int indexDe)
		{
			_desDansMain[indexDe] = true;
		}

		public void RelacherDe(int indexDe)
		{
			_desDansMain[indexDe] = false;
		}

		public void ProchainTour()
		{
			_tourJoueur = (_tourJoueur + 1) % _nombreJoueurs;
            _desDansMain = new List<bool> { true, true, true, true, true };
			_lancesRestants = NOMBRE_DE_LANCES_PAR_TOUR;
		}

		public List<int> Des
		{
			get { return _des; }
		}

		public List<bool> DesDansMain
		{
			get { return _desDansMain; }
        }

		public int TourJoueur 
		{
			get { return _tourJoueur; }
		}


		public int LancesRestants
		{
			get { return _lancesRestants; }
		}

		public int LancesParTour
		{
			get { return NOMBRE_DE_LANCES_PAR_TOUR; }
        }
    }
}
