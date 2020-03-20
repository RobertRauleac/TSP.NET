
    using System;
    public class PrimeNumberExample
    {
        public static void Main(string[] args)
        {
            int n, i,j, m = 0, flag = 0;
            Console.Write("Enter a Number : ");
            n = int.Parse(Console.ReadLine());
 
            for (i = n-1; i > 0; i--)
            {
            int divizori = 0;
                for (j = 2; j<=n; j++)
                {
                    if(i%j==0)
                    {
                    divizori++;
                    
                    }
                }

            if (divizori < 2)
            {
                Console.WriteLine(i);
                break;
            }
        }

            
            
        }
    }

