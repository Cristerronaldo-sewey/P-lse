using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

class Piakatrinholm
{

    static void Main()
    {

        

        int i = 0;

        do
        {
    i = new Random().Next(-10000, 1000000000);
  Console.WriteLine(i);

        }
        while (i != new Random().Next(-10000, 1000000000));


Console.Write("\nKoden til Mr.Fisters telefon er : {0}\n",i);   
  
Console.Write("Skriv Mr. Fisters telefon nummer :");
i = Convert.ToInt32(Console.ReadLine());


Console.Write("Mr.Fister er dum nu har vi pia´s telefon nummer");
    }

}

