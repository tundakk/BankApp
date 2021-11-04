using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenges
{
    public class CheckingAccount : BankAccounts
    {
        //fields        
        private double _checkBallance;
        //constructor
        public CheckingAccount(string accountOwner, int accountID, double ballance)
            : base(accountOwner, accountID)
        {
            _checkBallance = ballance;
        }
        //properties
        public double Ballance { get { return _checkBallance; } set { _checkBallance = value; } }
        //methods
        //shows amount on account
        public string ShowBallance()
        {
            return $"Your checking account contains: ${Ballance:n2}";
        }
        
        // Withdrawal() : base() { }
        public void Deposit(double deposit)
        {
            _checkBallance = _checkBallance + deposit;
        }
        public override string GetInfo()
        {
            return $"{AccountOwner},{AccountID},{Ballance}";
        }
    }
}