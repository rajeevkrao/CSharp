using System;

abstract class Mem{
   public abstract void Name(string Nam);
   public abstract void Age(int Ag);
}

class Member:Mem{
   public string VName;
   public int VAge;
   public override void Name(string Nam){
      VName = Nam; 
   }
   public override void Age(int Ag){
      VAge = Ag;
   }
}

class Abs{
   public static void Main(){
      Console.WriteLine("Enter your Name : ");
      Member mem = new Member();
      string name = Console.ReadLine();
      Console.WriteLine("Enter your Age : ");
      int age = Convert.ToInt32(Console.ReadLine());
      mem.Name(name);
      mem.Age(age);
      Console.WriteLine("Welcome, {0} \n Your age is {1}",mem.VName,mem.VAge);
   }
}
