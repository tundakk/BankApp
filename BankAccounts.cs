using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenges
{
    public class BankAccounts 
    // : IBankFilial
    {
        //fields
        protected string _accountOwner;
        protected int _accountID;
        // interface properties
        public string name { get; set; }
        public string region { get; set; }

        //constructor
        public BankAccounts(string accountOwner, int accountID)
        {
            _accountOwner = accountOwner;
            _accountID = accountID;
        }
        //properties
        public string AccountOwner { get { return _accountOwner; } set { _accountOwner = value; } }
        public int AccountID { get { return _accountID; } set { _accountID = value; } }
        // interface methods
        // public void setRegion(string s){
        //     s = name;
        //     System.Console.WriteLine($"The name of the branch is: {name}");
        // }

        //methods
        // return ballance


        // withdraw money
        // static decimal Withdrawal() { }
        public virtual string GetInfo()
        {
            return $"{AccountOwner},{AccountID}";
        }
        public virtual string ShowOptions()
        {
            return "Your options are as followed:\n\n Press 1 for \n\n Press 2\n\n Press 3\n\n Press 4\n\n Press 5\n\n Press 6\n\n Press 7";
        }
    }
}