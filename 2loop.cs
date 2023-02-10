using System;
namespace PreBasic
{
    class Loops
    {
        public void LearnLoops()
        {

            //Type casting methots of converting data types
            //byte a= 3233;
            //int b =a; // implicit casting

            //byte c = (byte)b; //explicit casting


            byte age = 23;
            string name
             = "Ram";
            // string m = name + " is" + age + "years old";
            string mi = $"{name} is {age} years old."; // string interpolation ie using $ sign
            var mii = $"{name} is {age} years old."; // var returns easily than other

            Console.WriteLine(mi);
            Console.WriteLine(mii);
        }
    }
}