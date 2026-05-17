using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCompte
{
    class TransactionHistory
    {
        public DateTime Period {get; init;}
        public string Category {get; init;}
        public double Amount {get; init;}
    }
}
