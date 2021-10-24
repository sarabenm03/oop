using System;
using System.Collections.Generic;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Option economie = new Option("Economie", 2);
            Option informatiqueIndustriele = new Option("Informatique Industriele", 2);
            Option mechatronique = new Option("Mechatronic", 2);

            Etudiant ali = new Etudiant("Ali Ahmed", 15.3);
            ali.choisirOption(economie);
            ali.choisirOption(informatiqueIndustriele);
            ali.choisirOption(mechatronique);
            Etudiant oumkeltoum = new Etudiant("Oumkeltoum Asmae", 19.5);
            oumkeltoum.choisirOption(informatiqueIndustriele);
            oumkeltoum.choisirOption(economie);
            oumkeltoum.choisirOption(mechatronique);
            Etudiant kenza = new Etudiant("Kenza Moreno", 15.5);
            kenza.choisirOption(economie);
            kenza.choisirOption(mechatronique);
            kenza.choisirOption(informatiqueIndustriele);
            Etudiant yahya = new Etudiant("Yahya Mustapha", 17.2);
            yahya.choisirOption(informatiqueIndustriele);
            yahya.choisirOption(mechatronique);
            yahya.choisirOption(economie);
            Etudiant ayman = new Etudiant("Ayman Amine", 14.2);
            ayman.choisirOption(mechatronique);
            ayman.choisirOption(informatiqueIndustriele);
            ayman.choisirOption(economie);
            Etudiant sadiq = new Etudiant("Sadiq Sulemane", 18.2);
            sadiq.choisirOption(economie);
            sadiq.choisirOption(informatiqueIndustriele);
            sadiq.choisirOption(mechatronique);

            List<Etudiant> etudiants = new List<Etudiant>();
            etudiants.Add(ali);
            etudiants.Add(sadiq);
            etudiants.Add(yahya);
            etudiants.Add(oumkeltoum);
            etudiants.Add(kenza);
            etudiants.Add(ayman);

            etudiants.Sort((etud1, etud2) => etud2.note.CompareTo(etud1.note));

            Console.WriteLine("Etudiants\tNote\tOptions");
            etudiants.ForEach(etud =>
            {
                Console.Write($"{etud.nom}\t{etud.note}\t");
                etud.options.ForEach(option =>
                {
                    Console.Write($"| {option.nom} ");
                });
                Console.WriteLine();
            });
            Console.WriteLine("\n");

            Etudiant.faireSelection(etudiants);

            economie.print();
            informatiqueIndustriele.print();
            mechatronique.print();
        }
    }
}
