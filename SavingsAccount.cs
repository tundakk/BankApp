using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenges
{
    public class SavingsAccount : BankAccounts
    {
        //fields
        private double _savBallance;
        //constructor
        public SavingsAccount(string accountOwner, int accountID, double ballance)
            : base(accountOwner, accountID)
        {
            _savBallance = ballance;
        }
        //properties
        public double Ballance
        {
            get
            {
                return _savBallance;
            }
            set
            {
                _savBallance = value;
            }
        }


        //methods
        public string ShowBallance(){
            return $"Your checking account contains: ${Ballance:n2}";
        }

        // public Withdrawal() {       
        
        //  }
         public void Deposit(double deposit){
           _savBallance =_savBallance + deposit;
        }
        public override string GetInfo()
        {
            return $"{AccountOwner},{AccountID},{Ballance}";
        }
    }
}