using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankSD
{
    interface IOptions
    {
        void addMoney(decimal money);
        void withdrowMoney(decimal money);
    }
}
