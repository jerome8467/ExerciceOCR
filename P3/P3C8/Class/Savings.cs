namespace GestionCompte
{
    class Savings : Account
    {

        private double _interestRate;
        public List<TransactionHistory> _historySavings = new List<TransactionHistory>();

        public Savings(double balance, double interestRate, Titular titulaire) : base(balance, "épargne", titulaire)
        {
            _interestRate = interestRate;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Votre taux d'intérêt s'élève à {_interestRate}");
        }

        public override void Deposit(double deposit)
        {
            base.Deposit(deposit);
            _historySavings.Add(new TransactionHistory { 
                Period = DateTime.Now,
                Category = "Dépôt",
                Amount = deposit });
        }

        public override void WithDraw(double amount)
        {
            if (amount > _currentBalance)
            {
                Console.WriteLine($"Transaction impossible - Votre solde n'est pas suffisant");
            }
            else
            {
                base.WithDraw(amount);
                _historySavings.Add(new TransactionHistory { 
                    Period = DateTime.Now,
                    Category = "Retrait",
                    Amount = amount });
            }

        }

    }
}