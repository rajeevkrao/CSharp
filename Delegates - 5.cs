using System;

namespace Delegates{
	class Del{
		public delegate void addSum(int a,int b);
		public delegate void subSub(int a,int b);
		public void sum(int a,int b){
			Console.WriteLine("Sum : "+(a+b));
		}
		public void sub(int a,int b){
			Console.WriteLine("Sub : "+(a-b));
		}
		public static void Main(){
			Del obj = new Del();
			addSum sum1 = new addSum(obj.sum);
			subSub sub1 = new subSub(obj.sub);
			sum1(1,2);
			sub1(3,2);
			Console.ReadLine();
		}
	}
}