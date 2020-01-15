using System;

namespace Chapter_6___Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] arg)
        {
            //ClassBasics_59();
            //ProertiesPartOne_61();
            Members_66();
            Console.Read();
        }
        static void ClassBasics_59()
        {
            Console.WriteLine("These are Object introductions displaying the Class Properties.");
            Console.WriteLine();


            //This is how I create an object of my class
            //also called an instance of a human with constructor requirements.
            Human Marcy = new Human("Marcy", "Kuhn" , "Blue" , 47);
            //this is how I can access public variable from outside and even change it
                    //Marcy.firstName = "nhukette";
                    //Marcy.lastName = "Fancy Pants";
            //This is how I can call Methods of the Class (Object Marcy)
            //Marcy is of Type(class) Human
            Marcy.IntroduceMyself();

            //Now what happens when we Introduce a new Human
            Human Ida = new Human("Ida", "Kuhn", "Blue", 68);
            Ida.IntroduceMyself();

            Human Missy = new Human("Missy", "Kuhn", "Green");
            Missy.IntroduceMyself();

            Human Jake = new Human("Jake", "Kuhn", 13);
            Jake.IntroduceMyself();
            
            Human JakeNew = new Human("Jake", "Cool");
            JakeNew.IntroduceMyself();

            Human MarcyNew = new Human("Marcy");
            MarcyNew.IntroduceMyself();

            Human MarcyOld = new Human( null, "Kuhn");
            MarcyOld.IntroduceMyself();


            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Console.ReadKey();
        }

        static void ProertiesPartOne_61()
        {
            Box box = new Box(3,4,5);
          //This is showing the properties of the box
            Console.WriteLine("The box length is    : " + box.GetLength());
            Console.WriteLine("The box width is     : " + box.Width);
            Console.WriteLine("The box height is    : " + box.Height);
            Console.WriteLine("The box volume is    : " + box.Volume);
            Console.WriteLine("The Front surface, (l x h) is : " + box.FrontSurface);
            Console.WriteLine("________________________________________");
            Console.WriteLine();
            Console.WriteLine("The is the Display Info :");
            Console.WriteLine();
            box.DisplayInfo();
            Console.WriteLine("Height ({0}) x Width ({1}) = {2}", box.Height, box.Width, box.Height * box.Width);
        }
        static void Members_66()
        {
            Members member1 = new Members();
            
            //we are calling a private method (SharingPrivateInfo) from within the public
            //method (Introducing) within the class.  This is the only way to retrieve private info from
            //within the class
            member1.Introducing(true);

        }
    }
}
