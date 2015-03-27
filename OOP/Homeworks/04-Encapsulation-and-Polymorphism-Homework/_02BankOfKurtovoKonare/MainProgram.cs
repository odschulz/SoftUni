using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BankOfKurtovoKonare
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            MortgageAccount mortgageAccount1 = new MortgageAccount(
                new IndividualCustomer("Mortgage Individual", "AA345"), 1000, 5);
            MortgageAccount mortgageAccount2 = new MortgageAccount(
                new CompanyCustomer("Mortgage Company", "AA348"), 5000, 2);

            LoanAccount loanAccount1 = new LoanAccount(
                new IndividualCustomer("Loan Individual", "1234CAB"), 2000, 10);
            LoanAccount loanAccount2 = new LoanAccount(
                new CompanyCustomer("Loan Company", "12345AB"), 10000, 7);

            DepositAccount depositAccount1 = new DepositAccount(
                new IndividualCustomer("Deposit Individual", "12666"), 15000, 2);
            DepositAccount depositAccount2 = new DepositAccount(
                new CompanyCustomer("Deposit Company", "12345AT"), 200000, 3);


            List<Account> allAccounts = new List<Account>() 
            {
                mortgageAccount1,
                mortgageAccount2,
                loanAccount1,
                loanAccount2,
                depositAccount1,
                depositAccount2
            };

            foreach (var account in allAccounts)
            {
                account.Deposit(100);
                Console.WriteLine(account);
                Console.WriteLine("Balance with interest for 6 months: " + account.CalculateInterest(6));
                Console.WriteLine();

            }

            List<IWithdrawable> withdrawableAccounts = allAccounts.Where(acc => acc is IWithdrawable)
                .Cast<IWithdrawable>()
                .ToList();


            foreach (var account in withdrawableAccounts)
            {
                if (account.Balance >= 100)
                {
                    account.Withdraw(100);
                }
            }

        }
    }
}
