using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
       
        int defVar = 1;
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while(defVar != 0)
        {
           
            Console.WriteLine($"Enter number: "); 
            int uNumber = int.Parse(Console.ReadLine());
            

            if (uNumber != 0)
            {
                numbers.Add(uNumber);
            }

            if(uNumber == 0)
            {
                defVar = 0;
                
                float sum = numbers.Sum();
                int count = numbers.Count();
                float avg = (sum / count);
                int max = numbers.Max();

                Console.WriteLine("The sum is:" + sum);
                Console.WriteLine("The average is:" + avg);
                Console.WriteLine("The largest number is:" + max);
                Console.WriteLine("End Program.");
            }
        }
        
        
    
    }
}