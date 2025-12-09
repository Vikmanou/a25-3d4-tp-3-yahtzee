using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_3
{
    internal class CalculateurScore
    {
        public static int Uns(int[] des)
        {
            int score = 0;
            foreach (int de in des)
            {
                if (de == 1) score += 1;
            }
            return score;
        }

        public static int Deux(int[] des)
        {
            int score = 0;
            foreach (int de in des)
            {
                if (de == 2) score += 2;
            }
            return score;
        }

        public static int Trois(int[] des)
        {
            int score = 0;
            foreach (int de in des)
            {
                if (de == 3) score += 3;
            }
            return score;
        }

        public static int Quatres(int[] des)
        {
            int score = 0;
            foreach (int de in des)
            {
                if (de == 4) score += 4;
            }
            return score;
        }

        public static int Cinqs(int[] des)
        {
            int score = 0;
            foreach (int de in des)
            {
                if (de == 5) score += 5;
            }
            return score;
        }

        public static int Six(int[] des)
        {
            int score = 0;
            foreach (int de in des)
            {
                if (de == 6) score += 6;
            }
            return score;
        }

        public static int ThreeOfAKind(int[] des)
        {
            int somme = 0;
            foreach (int de in des)
            {
                somme += de;
            }

            Dictionary<int, int> frequences = new Dictionary<int, int>();
            foreach (int de in des)
            {
                frequences[de] = frequences.ContainsKey(de) ? frequences[de] + 1 : 1;

                if (frequences[de] >= 3)
                {
                    return somme;
                }
            }

            return 0;
        }

        public static int FourOfAKind(int[] des)
        {
            int somme = 0;
            foreach (int de in des)
            {
                somme += de;
            }

            Dictionary<int, int> frequences = new Dictionary<int, int>();
            foreach (int de in des)
            {
                frequences[de] = frequences.ContainsKey(de) ? frequences[de] + 1 : 1;

                if (frequences[de] >= 3)
                {
                    return somme;
                }
            }

            return 0;
        }

        public static int FullHouse(int[] des)
        {
            Dictionary<int, int> frequences = new Dictionary<int, int>();
            foreach (int de in des)
            {
                frequences[de] = frequences.ContainsKey(de) ? frequences[de] + 1 : 1;
            }

            bool aTrois = frequences.Values.Contains(3);
            bool aDeux = frequences.Values.Contains(2);

            return (aTrois && aDeux) ? 25 : 0;
        }

        static List<List<int>> SEQUENCES_POSSIBLES_SMALL_STRAIGHT = new List<List<int>>()
        {
            new List<int>() {1, 2, 3, 4},
            new List<int>() {2, 3, 4, 5},
            new List<int>() {3, 4, 5, 6}
        };
        public static int SmallStraight(int[] des)
        {
            Dictionary<int, bool> valeursUniques = new Dictionary<int, bool>();
            foreach (int de in des)
            {
                valeursUniques[de] = true;
            }

            foreach (var sequence in SEQUENCES_POSSIBLES_SMALL_STRAIGHT)
            {
                bool trouvee = true;
                foreach (int valeur in sequence)
                {
                    if (!valeursUniques.ContainsKey(valeur))
                    {
                        trouvee = false;
                        break;
                    }
                }

                if (trouvee) return 30;
            }

            return 0;
        }

        static List<List<int>> SEQUENCES_POSSIBLES_LARGE_STRAIGHT = new List<List<int>>()
        {
            new List<int>() {1, 2, 3, 4, 5},
            new List<int>() {2, 3, 4, 5, 6}
        };
        public static int LargeStraight(int[] des)
        {
            Dictionary<int, bool> valeursUniques = new Dictionary<int, bool>();
            foreach (int de in des)
            {
                valeursUniques[de] = true;
            }

            foreach (var sequence in SEQUENCES_POSSIBLES_LARGE_STRAIGHT)
            {
                bool trouvee = true;
                foreach (int valeur in sequence)
                {
                    if (!valeursUniques.ContainsKey(valeur))
                    {
                        trouvee = false;
                        break;
                    }
                }
                if (trouvee) return 40;
            }

            return 0;
        }

        public static int Yahtzee(int[] des)
        {
            int dernierDe = des[0];
			for (int i = 1; i < des.Length; i++)
			{
				if (des[i] != dernierDe) return 0;
			}
			return 50;
        }

        public static int Chance(int[] des)
        {
            int somme = 0;
            foreach (int de in des)
            {
                somme += de;
            }
            return somme;
        }
    }
}
