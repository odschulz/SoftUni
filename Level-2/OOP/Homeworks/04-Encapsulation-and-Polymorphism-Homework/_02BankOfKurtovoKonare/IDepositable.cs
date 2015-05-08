using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    public interface IDepositable : IAccount
    {
        void Deposit(decimal deposit);
    }
}
