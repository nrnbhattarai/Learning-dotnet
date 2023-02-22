//LINQ Language integrated Querry

//refactoring techniques 


using System.Collections;
using System.Linq;

class Linq
{
    
    int[] numbers = { 3, 50, 27, 25, 64,  65, 55,33, 45, 6, 35, 3, 24, 13, 5, 88, 34, 21, 31 };

    public void LearnQuery()
    {
        PrintValues(numbers, "input arrays \n");
        // list all the even numbers from array

        //imparative
        // List<int> evens = new List<int>();
        // foreach(var num in numbers)
        // {
        //     if (num%2 == 0)
        //     {
        //         evens.Add(num);
        //     }
        // }


        // Declerative way 
        var evenNumbers = numbers.Where(num => num % 2 == 0);
        // Console.WriteLine("even numbers:");
        // foreach (var items in evenNumbers)
        //     Console.WriteLine(items + " ");

        PrintValues(evenNumbers, "Even numbers \n");

        // List all odd numbers which are divisible by 3

        var oddNumbers = numbers.Where(X => X % 2 != 0 && X % 3 == 0);
        // Console.WriteLine("odd numbers:");
        // foreach (var items in oddNumbers)
        //     Console.WriteLine(items + " ");
         PrintValues(oddNumbers, "odd numbers are listed here");




            // WeakReference can make one liner by

            var multipleOf5And7 = numbers.Where(x=> x%5==0&& x%7==0);
            PrintValues(multipleOf5And7, "multiple of 5 and 7 \n");

            // list all items less than 100 trailling 0 from numbers 

           // var numbersWithTrailing0 = numbers.Where(x=>x<100 && x%10==0);
            

            // Or this can be done by
            var numbersWithTrailing0 = numbers.Where(x=>x<100 && x.ToString().EndsWith("0"));

            PrintValues(numbersWithTrailing0, "numbers trailling with 0 ");

            //print squares of all items in array list
             var squares = numbers.Select(x=>x*x);
             PrintValues(squares, "square list are");


// Method syntax

             //print square roots of all less than 50
             var sqrts = numbers.Where(x=> x<50).Select(x=> Math.Sqrt(x).ToString("n3"));  // ToString for formatting  or Math.Round(Math.Sqrt(x), 2); 
             PrintValues(sqrts, "square roots are ");        
    


    // Expression syntax
    var sqRoots = from x in numbers 
    where x < 50
    select Math.Round(Math.Sqrt(x), 1); 



    //sort numbers 
    //  var sortNumbers = numbers.Order(x);
    //  PrintValues(sortNumbers, "sorted numbers  are");



//  list 5 items skipping first 2 items  for this we have skip and take operator
 var fiveItems = numbers.Skip(2).Take(5);
 PrintValues(fiveItems, "skipped items");

 // check if any item is evenn or not
 var isAnyEvenNumbers = numbers.Any(x=>x%2==0);
 Console.WriteLine($"any even: {isAnyEvenNumbers}");


//  check if all items are even numbers 
var areAnyEvenNumbers = numbers.All(x=>x%2==0);
 Console.WriteLine($"All even: {areAnyEvenNumbers}");


    }


// IEnumerable collection interface builtin <U> Generic method it can work for all float, doubles, data types
    void PrintValues<U>(IEnumerable<U> items, string label)
    {
        Console.Write($"{label}");
        foreach( var item in items)
        Console.WriteLine(item + " ");
    }

    public void LearnToQuerryOnObjectCollection()
    {
        Person p1 = new();
        p1.fullName = "Ram sharma";
        p1.gender = 'M';
        p1.height = 170.23f;

        Person p2 = new Person{ fullName= "hyam",  gender ='M', height = 162.23f};
         Person p3 = new Person{ fullName= "yam",  gender ='F', height = 163.23f};
          Person p4 = new Person{ fullName= "kam",  gender ='M', height = 164.23f};
           Person p5 = new Person{ fullName= "hayam",  gender ='F', height = 165.23f};
            Person p6 = new Person{ fullName= "hhyam",  gender ='M', height = 166.23f};

        List<Person> people = new List<Person>(){p1, p2,p3,p4,p5,p6};

        // list all females
      var females =  people.Where(x=>x.gender=='F');

      //List all males in ascending order of their height

      // Contextual keywords
       var males = from p in people where p.gender == 'm' orderby p.height
      select p;

      Console.WriteLine(males);
      Console.WriteLine(females);

    

        
        
    }

}