using System;
using System.Collections.Generic;​
using System.Linq;​
using System.Text;


namespace nm{
    class cla{
        public static void Main(String[] args){
            int a=1,b=2,c=3;
            if(a>b){
                if(a>c){
                    Console.WriteLine("A={0} is larger than B={1} and C={2}",a,b,c);
                }
                else if(b>c){
                    Console.WriteLine("B={0} is larger than A={1} and C={2}",b,a,c);
                }
                else{
                    Console.WriteLine("C={0} is larger than A={1} and B={2}",c,a,b);
                }
            }
        }
    }
}

