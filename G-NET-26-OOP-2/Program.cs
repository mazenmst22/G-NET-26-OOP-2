using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //    public class BankAccount
            //{
            //    public string Owner;
            //    public double Balance;

            //    public void Withdraw(double amount)
            //    {
            //        Balance -= amount;
            //    }
            //}
            //a)
            //This code violates Encaplsulation because the fields Owner and Balance are public,
            //allowing external code to directly access and modify them.
            //To fix this, we can make the fields private and provide public methods
            //to access and modify them.
            //Second violation is that there is no validation in the Withdraw method,
            //allowing for negative balances.
            //b)
            //To fix the code, we can make the fields private and provide public methods to access
            //and modify them. We can also add validation in the Withdraw method to prevent negative balances.
            //c)
            //Explain why exposing fields directly (as public) is considered a bad practice in OOP.
            //Exposing fields directly as public is considered a bad practice in OOP because it breaks encapsulation,
            //which is one of the fundamental principles of OOP. Encapsulation allows us to hide the internal state of an object
            //and only expose a controlled interface to interact with that state. When fields are public, external code can directly access and modify them,
            //
            #endregion
        }
    }
}
