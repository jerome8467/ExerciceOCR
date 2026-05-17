using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class ReadyToTxt
    {
        private UserProfile _user;
        public ReadyToTxt(UserProfile user)
        {
            _user = user;
        }

        public string GeneratTxt(List<TransactionHistory> ListCurrent, List<TransactionHistory> ListSavings)
        {

            string text = $"********** HISTORIQUE DES TRANSACTIONS SUR LE COMPTE {_user.accountCurrent._accountType.ToUpper()} **********";
            text += "\n\n";
            text += string.Join("\n", ListCurrent);

            text += "\n\n\n\n";

            text += $"********** HISTORIQUE DES TRANSACTIONS SUR LE COMPTE {_user.accountSavings._accountType.ToUpper()} **********";
            text += "\n\n";
            text += string.Join("\n", ListSavings);

            return text;
        }

    }
}
