// using system;
namespace PreBasic
{
class Selection
{
    //int personAge =23;  //camel casing
   public void LearnSelection() //pascal casing
    {

        // dotnet new console -n Fundamentals (to create folder)
        // cd .\Fundamentals to go inside folder
        // cd ..\ to come back outside
        // dotnet build/ Run 

        // class can contains methods and fields

        // Console.WriteLine("hello world");
        // string name =Console.ReadLine();
        // Console.WriteLine("enter the beautiful line " + name);


        //conditions selection statements
        // if-else else if  switch
        // branching


        // Console.WriteLine("enter your age");
        // short age = short.Parse(Console.ReadLine());
        // if (age < 18)
        // {
        //     Console.WriteLine("the man is child");
        // }
        // else if (age < 40)
        // {
        //     Console.WriteLine("you are adult now");
        // }
        // else if (age > 40 && age < 60)
        // {
        //     Console.WriteLine("you are in middle age");

        // }
        //     else
        //     {
        //         Console.WriteLine("you are old now");
        //     }


        // switch 

        // Console.WriteLine("enter your rashi");
        // string rashi = Console.ReadLine();
        // if ( rashi == "mesh")
        // {
        //     Console.WriteLine("Mesh rashi initials with ka kha ")
        // }
        // else if ( rashi == "kanya")
        // {
        //     Console.WriteLine("kanya  starts with ga gha");

        // }
        // else if (rashi == "brish")
        // {
        //     Console.WriteLine("brish starts with jha jhaa");
        // }

        // switch(rashi)
        // {
        //     case "mesh":
        //      Console.WriteLine("Mesh rashi initials with ka kha ");
        //      break;
        //      case "kanya":
        //      Console.WriteLine("kanya  starts with ga gha");
        //      break;
        //      case "brish":
        //       Console.WriteLine("brish starts with jha jhaa");
        //       break;
        //       default:Console.WriteLine("unknown rashi");
        //       break;



        // }

        // loops iteration
        // for, while do-while foreach
        // for (int counter = 1; counter < 5; counter++)
        // {
        //     Console.WriteLine("Nepal is beautiful");
        // }
        // for(byte num=1; num<=10; num++)
        // {
        //     Console.Write(" " + num);
        // }


       // print odd numbers

for (int num = 2; num < 50; num++)
        {
            if (num % 2 != 0)
                Console.WriteLine(num + " ");
        }


        //print all multiple of 3 and 5

        // for( int num=2; num <50; num++)
        // {
        //    if(num%3==0 && num%5 ==0)
        //     Console.Write(num +" ");
        // }


        //While and do while loop
        // int numb=1;
        // while(numb<=50)
        // {
        //     numb++; 
        //     Console.WriteLine(numb + " ");
        // }
        // string key = 'y';
        // while(key == 'y')
        // {
        //     Console.ReadLine("nepal");
        //     key = Console.ReadLine();
        // }


    }
    }
}