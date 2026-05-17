using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCompte;

namespace GestionCompte
{
    class Titular
    {
        private string _accountNumber;
        private string _titulaireName;

        public Titular(string numberAccount, string nameTitulaire)
        {
            _accountNumber = numberAccount;
            _titulaireName = nameTitulaire;
        }

        public void ShowUser()
        {
            Console.WriteLine($"Titulaire : {_titulaireName}");
            Console.WriteLine($"Numéro de compte : {_accountNumber}");
        }
    }

}
