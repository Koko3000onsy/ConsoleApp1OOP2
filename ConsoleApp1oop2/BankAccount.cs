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
        #region Q2
        //field: direct data storage,no validation,breaks encapsulation
        //properity: controlled access,can include validation,encapsulates data
        //private double w; 
        //private double h;
        //public double area
        //{
        //    get { return w*h ; }

        //}
        #endregion
        #region Q3
        //a. indexer : allows objects to be indexed like arrays, useful for collections
        //,clean syntax for accessing elements ,validate key and handle missing values ,make data in collections dictionary and caches
        //b. If index 10 is outside the valid range, it will throw an IndexOutOfRangeException at runtime.
        //To handle this, you can implement error handling in the indexer to check if the index is within the valid range before accessing the element.
        //If it's out of range, you can throw a custom exception or return a default value.
        //if (index < 0 || index >= students.Length) print "Index out of range" else return students[index];
        //c. Yes, you can have multiple indexers in a class, but they must differ in their parameter types or number of parameters to avoid ambiguity.
        //private list<string> owners=new list<string>();
        //public string this[int index]
        //{
        //    get
        //    {

        //        return owners[index];
        //    }
        //    set
        //    {

        //        owners[index] = value;
        //    }
        //}
        //public string this[string name]
        //{
        //    get
        //    {
        //        return owners.indexOf(name);
        //    }

        //    }
        //}


        #endregion
        #region Q4
        //a. static means the member belongs to the class not individual objects,
        //itself rather than an instance of the class.
        //b. static : Shared by all objects ,Belongs to the class,Accessed via Order.TotalOrders,Used for global data
        //item field :Each object has its own copy,Belongs to a specific object,Accessed via object order.Item,Used for object-specific data
        //no , static members can access only other static members directly, item belongs to specific object.
        #endregion
    }
}
