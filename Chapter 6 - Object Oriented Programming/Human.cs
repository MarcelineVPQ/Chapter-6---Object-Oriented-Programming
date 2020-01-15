using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_6___Object_Oriented_Programming
{
    //This class is a blueprint for a data type
        class Human
    {
        //want to create Member variables
        //adding public provides write access, otherwise the variable remains locked until we
        // us the "this" in the constructor, then we can make it private
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //Video 60 - Using Constructors
        // constructor
        //these are local variables,the: (string myfirstName, string lastName)
        //outside of the constructor, the variables are not known until we assign them.

        //parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            //Two ways to do this!! This enables you to change the name each time
            //by assigning the local variable to the member variable
            //firstName = myfirstName;
            //"this" means I want to have the last name of the "public string lastName;" member variable
            //the member variable not the local one
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        //Video 61 - Using MUlitple Constructors
        //default Constructor
        //we can create object type of Human that doesn't have any further information yet
        //We can create nearly  unlimited constructors, this is copied from Video 60 and then
        //the age parameter was removed
        
            // multiple versions with different parameters to meet different scenarios
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName)
        {
            this.firstName = firstName;
        }
        
        public Human()
        {
            Console.WriteLine("Empty Constructor Called(or Object Created).");
        }

        //Member Methods
        public void IntroduceMyself()
        {
            if(age != 0 && lastName != null && eyeColor != null && firstName !=null)
                Console.WriteLine("Hi, I am {0} {1}. I am {2} year old and my eye color is {3}", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I am {0} {1}. I am {2} years old.", firstName, lastName, age);
            }
            else if (eyeColor != null && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I am {0} {1}. My eye color is {2}.", firstName, lastName, eyeColor);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I am {0} {1}. ", firstName, lastName);
            }
            else if (lastName != null && firstName == null)
            {
                Console.WriteLine("They call me {0}. ", lastName);
            }
            else if(firstName != null)
            {
                Console.WriteLine("Hi, I am {0}. ", firstName);
            }
            

        }

    }
}
