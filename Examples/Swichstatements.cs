using System.Linq.Expressions;

class SwitchstatementOPGAVE11 {

static void Main(string[] args)     {   

int a = 1;
int b = 5;
int c = 7;

Console.WriteLine();

Math.Sqrt(a);
Console.WriteLine(Math.Sqrt(a));
Math.Sqrt(b);
Console.WriteLine(Math.Sqrt(b));
Math.Sqrt(c);
Console.WriteLine(Math.Sqrt(c));

double d, x1,x2;
    Console.Write("\n\n");

    Console.Write("Regn andengrads ligning :\n");

    Console.Write("\n\n");

Console.Write("input value of a : ");
a = Convert.ToInt32((Console.ReadLine()));

Console.Write("input value of b : ");
b = Convert.ToInt32((Console.ReadLine()));

Console.Write("input value of c : ");
c = Convert.ToInt32((Console.ReadLine()));

d=b*b-4*a*c;
if (d==0)
{
    Console.Write("Begge råder er samme som. \n");
    x1 = -b/(2.0*a);
    x2 = x1 ;
    Console.Write("Root1= {0}\n",x1);
    Console.Write("Root2= {0}\n",x2);
    
}
else if(d>0)
{

Console.Write("both roots are > 0 ") ;
x1=(-b+Math.Sqrt(d))/(2*a);
x2=(-b+Math.Sqrt(d))/(2*a);

 Console.Write("Root1= {0}\n",x1);
 Console.Write("Root2= {0}\n",x2);



    }
    else
     Console.Write("Root are imeainary;\nNo Solution. \n\n");
      }
            } 




