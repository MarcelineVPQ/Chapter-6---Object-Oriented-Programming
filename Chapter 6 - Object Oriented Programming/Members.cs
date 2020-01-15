using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Chapter_6___Object_Oriented_Programming
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property (exposes JobTitle safely)
        //  properties always start with a capital
        public string JobTitle 
        { 
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        
        }

        //public member Method - can be called from other classes
        // Methods within a class are called Members
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else 
            {
                Console.WriteLine("Hi my name is {0} and my job title is {1}. I am {2} year(s) old.", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is: {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 20000;
            JobTitle = "Computer Programmer";
            
            Console.WriteLine("Object Created.");
        }

        //member - finalizer - destructor
        //Can only create 1 finalizer (also known as destructor)
        //per Class start it with the ~ symbol
        //it can not be overloaded and it can not be called
        //Only use a finalizer if you have something useful to perform.
        //otherwise it just uses up performance
        ~Members()
        {
            // this is here for Cleanup Statements

            Debug.Write("Debug: Destruction of Members Object");
        }


    }
}
