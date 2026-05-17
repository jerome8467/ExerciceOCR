using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class Current : Account
    {

        private double _overdraftLimit;
        public List<TransactionHistory> _historyCurrent = new List<TransactionHistory>();

        public Current(double balance, double overdraft, Titular titulaire) : base(balance, "courant", titulaire)
        {
            _overdraftLimit = overdraft;
        }

        public override void Deposit(double deposit)
        {
            base.Deposit(deposit);
            _historyCurrent.Add(new TransactionHistory {
                Period = DateTime.Now,
                Category = "Dépôt",
                Amount = deposit});
        }

        public override void WithDraw(double amount)
        {
            if(amount > _currentBalance + _overdraftLimit)
            {
                Console.WriteLine($"Transaction impossible - Votre découvert autorisé de {_overdraftLimit}€ ne suffit pas");
            }
            else
            {
                base.WithDraw(amount);
                _historyCurrent.Add(new TransactionHistory {
                    Period = DateTime.Now,
                    Category = "Retrait",
                    Amount = amount });
            }

        }

    }
}




