using System;

namespace MLI{
	class Company{
		public string CompanyName(){
			return "Asus";
		}
	}
	class Type:Company{
		public string PCType(){
			return "laptop";
		} 
	}
	class Model:Type{
		public string ModelName(){
			return "TUF";
		}
	}
	class Laptop{
		public static void Main(){
			Model pc = new Model();
			Console.WriteLine("Laptop : {0} {1} {2}",pc.CompanyName(),pc.PCType(),pc.ModelName());
		}
	}	
}