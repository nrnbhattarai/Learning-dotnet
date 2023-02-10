class Method
{
    // returns nothings, takes no parameter
    public void PrintMessage()
    {
        Console.WriteLine("Nepal is beautiful country");
    }


    //returns nothing, takes parameter



    public void Print(string message) //method overloading same name with different signature
    {
        Console.WriteLine(message);
    }

    // returns something, takes no argument
    public string GetMessage()
    {
        var city = "kathmandu";
        return city;
    }

    //returns something and takes some value
    public double Add(double a, double b)
    {
        return a + b;
    }

    //Expressiion bodied members
    public double Adds(double a, double b) => a + b;



    // takes arguments or not , returns multiple value 

    //find sum and product of supplied number
    // concept of tuples

    public (float, float) GetSumAndProduct(float a, float b)
    {
        var sum =a+b;
        var product = a*b;
        return (sum, product);
    }
//  public double  FindAverage(float a, float b, float c) alternative
public double FindAverage(params int[] items)

 {
    var sum = 0;
  foreach(var i in items)
  {
   sum = sum+i;
  }

  var average = (double)sum/items.Length;
    //  var sum = a + b + c;
    //  var avg = (double)sum/3;
     return average;
 }


}