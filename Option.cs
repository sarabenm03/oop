using System;
using System.Collections.Generic;

namespace oop
{
    class Option
    {
        public string nom;
        public int espaceDisponible;
        public List<Etudiant> etudiants = new List<Etudiant>();

        public Option(string _nom, int _espaceDisponible)
        {
            nom = _nom;
            espaceDisponible = _espaceDisponible;
        }

        public bool ajouterEtudiant(Etudiant etudiant)
        {
            if (etudiants.Count >= espaceDisponible) return false;
            etudiants.Add(etudiant);
            return true;
        }

        public void print()
        {
            Console.WriteLine($"Option {nom} Espace Disponible => {espaceDisponible}");
            Console.WriteLine("Etudiant\tNote");
            etudiants.ForEach(etudiants =>
            {
                etudiants.print();
            });
            Console.WriteLine("\n");
        }
    }
}
