using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
namespace PreBasic
{
    class Programs

    {
        static void Main()
        {
            // Loops l = new();
            // l.LearnLoops();

            Selection sec = new();

            // Method me = new();
            // me.PrintMessage();
            // me.Print("hello how is it");
            // var a = me.GetMessage();
            // Console.WriteLine(a);
            // var sum = me.Add(4.5, 56.8);
            // Console.WriteLine(sum);
            // var product = me.GetSumAndProduct(4, 5);
            // Console.WriteLine(product);
            // var ab = me.FindAverage(4, 3, 2,5,6,8);
            // var abc = me.FindAverage(4, 3, 2,5,8);
            //  Console.WriteLine(ab);
            //  Console.WriteLine(abc);


            // Vehicle car1 = new();
            // Vehicle truck1= new();
            // car1.Brand ="mki";
            // car1.Model="Nexon ev";
            // car1.Color ="black";
            // car1.PrintDetails();
            // truck1.PrintDetails();

            // Fifa worldcup2016 = new();
            // worldcup2016.host = "russia";
            // worldcup2016.year= new DateTime(2018, 2,3);
            // worldcup2016.winner ="France";    
            // worldcup2016.teams= new String[] {"france", "Germany", "Argentina", "Brazil"};

            // for this alternatives use constructor

            Fifa worldcup2022 = new("Qatar");
            Fifa worldcup2002 = new("Qatar", new DateTime(2002, 02, 04), "Nepal", new string[] { "Nepal", "Brazil", "argentina" });

            Fifa.groups = 10; //static value is accessed through classes only to make changes 
                              // if it is const instead of static then we cant set the value 







        }
    }
}