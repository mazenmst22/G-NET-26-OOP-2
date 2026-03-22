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
            #region Q3
            //a) What is `this[int index]` called? Explain its purpose.
            //Answer:
            //`this[int index]` is called an indexer in C#. It allows an
            //object to be indexed like an array. The purpose of an indexer is to provide a way to access elements of a class or struct
            //using array-like syntax. It is defined using the `this` keyword followed by an index parameter,
            //and it can have a getter or setter to define how the elements are accessed or modified.
            //b)1)What happens if someone writes `register[10] = "Ali";` ?
            //Answer:
            //this will throw IndexOutOfRange() exception because the index 10 is out of the bounds of the array or Collection.
            //2)How could you make the indexer safer?
            //To make the indexer safe, we should check the bounds before getting the value
            //of the element in the collection or setting it.
            //
            //Example of getting the indexer safe:
            #region Example Q3
            //-------------------------------
            //    public string this[int index]
            //{
            //    get
            //    {
            //        if (index >= 0 && index < names.Length)
            //        {
            //            return names[index];
            //        }
            //        return -1;
            //    }
            //    set
            //    {
            //        if (index >= 0 && index < names.Length)
            //        {
            //            names[index] = value;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Student index Out of bounds. Try registering with a valid index");
            //        }
            //    }
            //}
            //--------------------------------
            #endregion
            //c)can a class can have more than one indexer?
            //if yes, give an example of when that would be useful.
            //Answer:
            //Yes, a class can have more than one indexer.
            //This can be useful when you want to provide different ways to access the data in the class.
            //This known as indexer overloading, where you can have multiple indexers with different parameter types
            //or numbers of parameters.
            //Example:
            #region Example2 Q3
            /*-------------------------------
            public class StudentRegister
            {
                private string[] names = new string[5];
                public string this[int index] //Indexer1
                {
                    get { return names[index]; }
                    set { names[index] = value; }
                }
                public int this[string name] //Indexer2
                {
                    get 
                    { 

                        for (int i = 0; i < names.Length; i++)
                        {
                            if (names[i] == name) 
                            {
                                return i; 
                            }
                        }
                        return -1;
                    }
        
                }
            }


            //-------------------------------*/
            #endregion
            #endregion
            #region Q4
            //a) What does the `static` keyword mean on `TotalOrders`?
            //How is it different from the `Item` field?
            //Answer:
            //A static keyord here means that 'TotalOrders' field belongs to the class 
            //intself and not to any specfic instanc4 (object) of the class. This 
            //means that all instances share the same value of the field 'TotalOrders'.
            //As for 'Item' field, it is an instance field as the static keyword does not exist,
            //which means that each instance of the class has its own copy of the 'Item' field.
            //------------------------------------
            //b)Can a static method inside `Order` access the `Item` field directly?
            //Why or why not?
            //Answer:
            //No, a static method inside the `Order` class cannot access the `Item` field directly
            //because `Item` is an instance field, and static methods do not have access to instance members.
            //Static methods can only access static members of the class. To access the `Item` field,
            //a static method would need to create an instance of the `Order` class or receive an instance
            //as a parameter.

            #endregion
        }
    }
}
