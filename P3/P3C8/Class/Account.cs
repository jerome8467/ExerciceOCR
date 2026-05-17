using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class Account
    {
        protected double _currentBalance;
        public string _accountType;
        protected Titular _titulaire;

        public Account(double balance, string type, Titular titulaire)
        {
            _currentBalance = balance;
            _accountType = type;
            _titulaire = titulaire;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Vous avez sur votre compte {_accountType} : {_currentBalance}");
        }

        public virtual void Deposit(double deposit) 
        {
            _currentBalance += deposit;
            Console.WriteLine($"Votre dépot de {deposit} a bien été enregistré");
            Show();
        }

        public virtual void WithDraw(double amount)
        {
            _currentBalance -= amount;
            Console.WriteLine($"Votre retrait de {amount} a bien été enregistré");
            Show();
        }
    }

}
