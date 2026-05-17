using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionCompte
{
    class Run
    {
        public List<string> Menu;
        public UserProfile User;
        public void StartProgram()
        {
            InitalizeProfil();
            InitializeMenu();
            new Engine(User, Menu).Program();
        }


        

        private void InitalizeProfil()
        {
            Titular user = new Titular("Jerome", "001");
            Current current = new Current(2450, 300, user);
            Savings savings = new Savings(12750, 1.4, user);
            User = new UserProfile(user, current, savings);
        }
        private void InitializeMenu()
        {
            Menu = new List<string>
            {
                "[I] Voir les informations sur le titulaire du compte",
                "[CS] Compte courant - Consulter le solde",
                "[CD] Compte courant - Déposer des fonds",
                "[CR] Compte courant - Retirer des fonds",
                "[ES] Compte épargne - Consulter le solde",
                "[ED] Compte épargne - Déposer des fonds",
                "[ER] Compte épargne - Retirer des fonds",
                "[X] Quitter"
            };

        }
        public static void PushEnter()
        {
            Console.WriteLine("Appuyez sur Entrée pour afficher le menu.");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                Console.WriteLine("Mauvaise touche");
                Console.WriteLine("Appuyez sur Entrée pour afficher le menu.");
            }
        }
        public static double InputDouble(string message)
            {
                while (true)
                {
                    double nombre;
                    Console.Write(message);
                    while (!double.TryParse(Console.ReadLine(), out nombre))
                    {
                        Console.WriteLine("Erreur de saisie, merci de rentrer un nombre positif");
                    }

                    if (nombre > 0)
                    {
                        return nombre;
                    }
                    else
                    {
                        Console.WriteLine("Erreur de saisie, rentrer un nombre superieur à zéro");
                    }
                }
            }


        
    }
}