using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
// using InheritanceExample;
namespace PreBasic
{
    class Programs

    {
        static void Main()
        {
            // Loops l = new();
            // l.LearnLoops();

            // Selection sec = new();

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

            // Fifa worldcup2022 = new("Qatar");
            // Fifa worldcup2002 = new("Qatar", new DateTime(2002, 02, 04), "Nepal", new string[] { "Nepal", "Brazil", "argentina" });

            //Fifa.groups = 10; //static value is accessed through classes only to make changes 
            // if it is const instead of static then we cant set the value 

            //   C c1=new();
            //   c1.y

            // inheritance
            // IShape shape = new Rectangle(4f, 6.6f);
            // var a = shape.GetArea();
            // var b = shape.GetPerimeter();
            // Console.WriteLine(a);
            // Console.WriteLine(b);

            // shape = new Square(23.4f);
            // var sa = shape.GetArea();
            // var sp = shape.GetPerimeter();
            // Console.WriteLine(sa);
            //     Console.WriteLine("The perimeter is " + sp);

            // //shape = new Circle(3.14f);
            // var cp = shape.GetPerimeter();
            // Console.WriteLine("The perimeter is circle " + cp);


            // Generic
            // Generic g = new();
            // g.PrintDetails("hi hello world");
            // g.PrintDetails<bool>(false);
            // g.PrintDetails('F');


            //   FileIO fi = new();
            //  // fi.CreateFile();
            //   fi.CreateDirectory();
            //   fi.CreateDirectoriesAndFiles();
            //   FileIOLoop fii = new();
            //   fii.CreateDirectoriesFiles();



            // LinQ
            // Linq lin = new Linq();
            // lin.LearnQuery();


//learn to querry on object collection

// Linq li = new();
// li.LearnToQuerryOnObjectCollection();

        }
    }
}