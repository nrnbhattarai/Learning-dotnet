// class Vehicle
// {
//     // kiss --keep it stupid simple
//     string brand;
   
//     public DateTime modelYear;
//     public string model;
//      public string Model //in auto implemented property { get; set;}
//     {
//        get     //full implemented property 
//        { 
//         return model;
//        }
//        set 
//        {
//         model=value;
//        }
//     }
//     public string color;
//     public string Color 
//     {
//         get
//     {
//         return color;
//     }
//     set
//     {
//         color=value;
//     }
//     }
//     public long serialNumber;
//     public string Brand
//     {
//         get
//         {
//             return brand;

//         }
//         set
//         {
//             if (value.Length > 2)
//             {
//                 brand = value;
//             }
//         }
//     }

//     public void PrintDetails()
//     {
//         var details = $"Brand:{Brand}, model:{Model}, color code:{Color}, serial Number:{serialNumber}";//string interpollation
//         Console.WriteLine(details);
//     }
// }