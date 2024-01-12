using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Stockprices{

    public static void Main()
    {

//         string[] stocknames = { "stockA", "stockB", "stockC", "stockD"};
//         double[,] stockPrices = {
                        
//                     {3,7,8,10,45},
//                     {5,6,12,15,60},
//                     {7,23,25,34,46},
//                     {2,3,223,35,6}

//                     };
//         Console.WriteLine("Stock priser over tiden");
    
//     //Beregningerne
//         for(int i = 0; i < stocknames.Length; i++)

// {
//    double[] pricesForStock = new double[stockPrices.GetLength(1)];

//    for(int j = 0; j < stockPrices.GetLength(1); j++)
//     {
//          pricesForStock[j] = stockPrices[i, j];  
//             }

//     double averagePrice = CalculateAverage(pricesForStock);
            
//             Console.WriteLine($"{stocknames[i]} - Average Price: {averagePrice}");
//          }
         
//                     double CalculateAverage(double[] prices)
//                     {
//                     double sum = 0;

//                     foreach (var price in prices)
//                     {
//                         sum += price;
//                     }

//                     return sum / prices.Length;
                    
                
//                 }
//             }
//         }
            
      
//         string[] stocknames = { "stockA", 
//             "stockB", 
//             "stockC", 
//             "stockD", 
//             "stockE",
//             "stockF", 
//             "stockG", 
//             "stockH",
//             "stockI", 
//             "stockJ" };
//         int[] value = { 2, 4, 5, 32, 23, 234, 2, 1, 0, 10 };
//         int[] stockprice =
//         value;
    

        

//         for (int i = 0; i < stocknames.Length; i++)
//         {
//             int[] priceForStock = new int[stockprice.Length];

//             for (int j = 0; j < stockprice.Length; j++)
//             {
//                 priceForStock[j] = stockprice[i];
//                 Console.WriteLine($"The names of the stocks: {i} is {stocknames[i]}");
//             }

//             int averagePrice = CalculateAverage(priceForStock);

//             Console.WriteLine($"{stocknames[i]} - Average Price: {averagePrice}");
//         }
//     }

//     static int CalculateAverage(int[] prices)
//     {
//         int sum = 0;

//         foreach (int price in prices)
//         {
//             sum += price;
//         }

//         return sum / prices.Length;
//     }
// }

      string[] stocknames = { "stockA", 
            "stockB", 
            "stockC", 
            "stockD", 
            "stockE",
            "stockF", 
            "stockG", 
            "stockH",
            "stockI", 
            "stockJ" };
        int[] value = { 2, 4, 5, 32, 23, 234, 2, 1, 0, 10 };
        int[] stockprice =
        value;
    

       

        for (int i = 0; i < stocknames.Length; i++)
        {
            int[] priceForStock = new int[stockprice.Length];

            for (int j = 0; j < stockprice.Length; j++)
            {
                priceForStock[j] = stockprice[i];
                 Console.WriteLine($"The names of the stocks: {i} is {stocknames[i]}");
            }

          
    }
}
   
}