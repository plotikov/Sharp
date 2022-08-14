using System;

namespace Sharp { }

class Program
{

    static void Main()
    {
        
         Console.WriteLine(" Сумма вклада: ");

        double n1=Convert.ToDouble(Console.ReadLine());

         if (n1 < 100) { 
             n1 *= (double)Math.Round(1.05d, 2);
             

         }
         else if (n1 >= 100 && n1 <= 200){
             n1 *= (double)Math.Round(1.07d, 2);
            
         }
         else if (n1 > 200)
         {
             n1 *= (double)Math.Round(1.1d, 2);
             
         }

        Console.WriteLine($" Сумма вклада с %: {n1}");




    }
}