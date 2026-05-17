using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionCompte
{
    class ActionHandler
    {

        private UserProfile _user;
        public ActionHandler(UserProfile user) 
        {
            _user = user;
        }


        public void Execute(string selection)
        {

            switch (selection) 
            {
                //Voir les informations sur le titulaire du compte
                case "I":
                    _user.userInfo.ShowUser();
                    break;

                //Compte courant - Consulter le solde
                case "CS":
                    _user.accountCurrent.Show();
                    break;

                //Compte courant - Déposer des fonds
                case "CD":                   
                    double cd = Run.InputDouble("Veuillez saisir le montant de votre dépot sur votre compte courant : ");
                    _user.accountCurrent.Deposit(cd);
                    break;

                //Compte courant - Retirer des fonds
                case "CR":
                    double cr = Run.InputDouble("Veuillez saisir le montant de votre retrait sur votre compte courant : ");
                    _user.accountCurrent.WithDraw(cr);
                    break;

                //Compte épargne - Consulter le solde
                case "ES":
                    _user.accountSavings.Show();
                    break;

                //Compte épargne - Déposer des fonds
                case "ED":
                    double ed = Run.InputDouble("Veuillez saisir le montant de votre dépot sur votre compte épargne : ");
                    _user.accountSavings.Deposit(ed);
                    break;

                //Compte épargne - Retirer des fonds
                case "ER":
                    double er = Run.InputDouble("Veuillez saisir le montant de votre retrait sur votre compte épargne : ");
                    _user.accountSavings.Deposit(er);
                    break;
            }

        }
    }
}
