using System;
namespace dotnet
{
    class BCA41062
    {
        public static void Main(string[] args)
        {
            int a=10, b=5, c=7;
            if(a>b && a>c)
            {
                if(a>c)
                {
                    Console.WriteLine("A is greatest");
                }                
            }
            else if(b>c)
            {
                Console.WriteLine("B is greatest");
            }
            else
            {
                Console.WriteLine("C is greatest");
            }
        }
    }
}