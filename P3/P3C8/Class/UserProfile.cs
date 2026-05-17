using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class UserProfile
    {

        public Titular userInfo { get; private set; }
        public Current accountCurrent { get; private set; }
        public Savings accountSavings { get; private set; }

        public UserProfile(Titular titular, Current current, Savings savings)
        {
            userInfo = titular;
            accountCurrent = current;
            accountSavings = savings;
        }


    }
}
