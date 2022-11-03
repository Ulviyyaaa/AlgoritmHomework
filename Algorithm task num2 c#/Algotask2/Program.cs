using System;
using System.Collections.Generic;
using System.Text;
namespace task2 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cem = 0, i, j, k, l;
            Console.WriteLine("Massiv elementlerinin sayini yazin");
            n = Int16.Parse(Console.ReadLine());
            int[] massiv = new int[n];
            Console.WriteLine("Massiv elementlerini sirayla alt-alta yazin");
            for (i = 0; i < n; i++)
            {
                massiv[i] = Int16.Parse(Console.ReadLine());
                
            }
            
            for (j = 0; j < n; j++)
            {
                for (k = 0; k < n; k++)
                {
                    
                    if (massiv[j] == massiv[k])
                    {
                        
                        
                        for (l = 0; l < j; l++)
                        {
                            
                            if (massiv[l] == massiv[j])
                                
                                cem = -1;
                        }
                        cem++;
                    }
                }
                if (cem != 0)
                    Console.WriteLine(massiv[j] + " regemi " + cem + " defe tekrar olunub");
                cem = 0;
            }
            Console.ReadKey();
        }
    }
}