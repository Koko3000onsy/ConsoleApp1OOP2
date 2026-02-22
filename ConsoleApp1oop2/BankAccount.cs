using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1oop2
{
    public class BankAccount
    {
        #region Q1
        //public string owner; //private
        //public double balance;//private
        //// first error :accourding to incapulation principle we should make the fields private and use public methods to access them

        //public void withdraw(double amount) 
        //{
        //    //second error : we should check if the balance is sufficient before withdrawing ,
        //    //we should also check if the amount is positive before withdrawing
        //    //balance - = amount;
        //    this.balance -= amount;
        //    //third error : we should use this.balance to access the balance field 
        //    //'we should use geeters and setters to access the balance field instead of directly accessing it or properity.
        //    //Why exposing public fields is bad in OOP
        //    //1. break data hiding : External code can change internal state freely.
        //    //2 . No control over changes : Can't validate or restrict modifications.
        //    //3. Tight coupling : External code becomes dependent on internal structure.
        //    //4. Maintenance issues : Changing internal structure can break external code.

        //}
        #endregion
    }
}
