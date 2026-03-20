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
            //Answer: 
            //Exposing fields directly as public is considered a bad practice in OOP because it breaks encapsulation,
            //which is one of the fundamental principles of OOP. Encapsulation allows us to hide the internal state of an object
            //and only expose a controlled interface to interact with that state (using properties and behaviours). When fields are public,
            //external code can directly access and modify them, making it vulnerable to unintended change and security risks.
            //
            #endregion
            #region Q2
            //1) What is the difference between a field and a property in C#?
            //Answer: 
            //A field in C# is a variable declared directly in a class or a struct,
            //while a property is a special type of method that acts as a variable to 
            //control the data and how is set and retrieved (Get()).
            //2) How a property contain logic
            //A property can contain logic like any other method, 
            //as we can add a condition, or a some calculations before returning the value or setting it.
            //3) Give an exaple of a property with logic in its getter or setter.
            //Answer:
            //Public class Rectangle{
            //private double Width;
            //private double Height;
            //public double Area
            //{
            //get{
            //  if(Width > 0 && Height > 0){
            //    return Width * Height;}
            //return new ArgumentException("Width and Height must be positive numbers");
            // }
            //}

            #endregion
        }
    }
}
