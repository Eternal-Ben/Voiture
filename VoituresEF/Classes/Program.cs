using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.VoituresEF.Data;

namespace VoituresEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexte = new Contexte())
            {
                var marques = contexte.Marque.toList();
            }
            private static void CreerMarque()

            {
                Console.WriteLine();
                Console.WriteLine(">NOUVELLE MARQUE");

                Console.Write("Nom de la marque: ");
                var nomMarque = Console.ReadLine();

                var connexion = new Marque();
                marque.Nom = nomMarque;

                using (var contexte = new Contexte())
                {
                    contexte.Marques.Add(marque);
                    contexte.SaveChanges();
                }
            }


            var commande = connexion.CreateCommand();

            commande.CommandText =

                "INSERT INTO Marques (Nom) VALUES(@NomMarque)";

            commande.Parameters.AddWithValue("@NomMarque", nomMarque);



            commande.ExecuteNonQuery();



            connexion.Close();

        }
        private static void SupprimerMarque()

        {
            Console.WriteLine();
            Console.WriteLine("modvmDVMU")


             }
    }


     
    }
}
