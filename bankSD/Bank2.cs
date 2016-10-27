using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankSD
{
    class Bank2 : IOptions
    {
        private decimal balance;
        public void addMoney(decimal money)
        {
            balance += money;
        }

        public void withdrowMoney(decimal money)
        {
            balance -= money*0.99M;
        }

        public override string ToString()
        {
            return Convert.ToString(balance);
        }
    }
}
