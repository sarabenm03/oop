using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class Etudiant
    {
        public string nom;
        public double note;
        public List<Option> options = new List<Option>();
        public int limitOption;

        public Etudiant(string _nom, double _note, int _limitOption = 3)
        {
            nom = _nom;
            note = _note;
            limitOption = _limitOption;
        }

        public bool choisirOption(Option option)
        {
            if (options.Count >= limitOption) return false;
            options.Add(option);
            return true;
        }

        public void print()
        {
            Console.WriteLine($"{nom}\t{note}");
        }

        public static void faireSelection(List<Etudiant> etudiants)
        {
            for (int i = 0; i<etudiants.Count; i++)
            {
                Etudiant etud = etudiants[i];
                int optionCurrent = 0;
                while (true)
                {
                    try
                    {
                        bool estSelecte = etud.options[optionCurrent].ajouterEtudiant(etud);
                        if (!estSelecte)
                        {
                            optionCurrent++;
                        }else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }
    }
}
