using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_6___Object_Oriented_Programming
{
    class Box
    {
        // challenge: create a read only property "FrontSurface" which calculates the
        // front surface based on height and length

        //these are member variables, not just simple variables
        //we made them private so no one except this class could access it directly.
        private int length;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }
        /*
        public int Width
        {
            get
            {
                return this.width;
            }
            set 
            {
                this.width = value;
            }
        }
        */

        public int Volume
        {
            get
            {
                return this.length * this.Width * this.Height;
            }

        }

        //this is a property, make sure to use a Capital Letter to signify it
        //you can choose to implement just a setter or getter or both.
        public int Height
        {
            get
            {
                return height;
            }
            
            //this set shows how to ensure you have a positive number as a result for your height :-)
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        public int FrontSurface
        {
            get
            {
                return length * height;
            }
        }

        //Lets add a constructor video 64 12:22
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            //we are talking about the property here, so we don't need the keyword "this"
            Width = width;
        }

        //Setters and Getters are important for not giving the user direct access to the variables / data.
 
        //This is called a setter
        //we can finely tune what the user access through if then statements as well.
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than zero (0).");
            }
            this.length = length;
        }

        //this is called a getter
        public int GetLength()
        {
            return this.length;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length: {0} Width: {1} Height: {2};  The volume is: {3}", length, Width, height, volume = length*Width*height);
        }
    }
}
