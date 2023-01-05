using System;
namespace parout{
    class parout{
        public static void sum(params int[] a){
            int sum=0;
            foreach(int i in a)
                sum=sum+i;
            Console.WriteLine("Sum :"+sum);
        }
        public static void add(int a,int b,out int c){
            c=a+b;
        }
        public static void Main(){
            int a,b,c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum(a,b,11,12,13);
            add(a,b,out c);
            Console.WriteLine("Sum of A&B: "+c);            
        }
    }
}