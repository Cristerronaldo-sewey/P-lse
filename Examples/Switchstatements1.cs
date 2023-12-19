/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Opgave12 {

static void Main()     {   
double rl,phy,che,ca,total;
double per;
string nm,div;

Console.Write("\n\n");
Console.Write("Udregn procent og divition");
Console.Write("\n\n");

Console.Write("Hvor mange dumme unger er der :");
rl = Convert.ToInt32(Console.ReadLine());

Console.Write("Navne på de klamme elever :");
nm = Console.ReadLine()!;

Console.Write("Fysik");
phy = Convert.ToInt32(Console.ReadLine());
Console.Write("Kemi");
che = Convert.ToInt32(Console.ReadLine());
Console.Write("Applicationer");
ca = Convert.ToInt32(Console.ReadLine());

total = phy + che + ca;
per = total/3.0;
if (per>=60)
div="first";
else
if (per<60&&per>48)
div="second";
else
if(per<60&&per>36)
div="pass";
else
div="fail";
   Console.Write("\nRoll NEEEEEJ : {0}\nName of Student : {1}\n",rl,nm);
       Console.Write("Amen fysik da : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n",phy,che,ca);
       Console.Write("Det godt du heeeeeej = {0}\nPercentage = {1}\nDivision = {2}\n",total,per,div);

                } 

 }
 */