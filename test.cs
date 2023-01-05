using System;

namespace MLI{
  class Company{
    public string CompanyName(){
      return "Kawasaki";
    }
  }
  class Type:Company{
    public string TType(){
      return "Ninja";
    } 
  }
  class CC:Type{
    public string CCC(){
      return "H2R";
    }
  }
  class Bike{
    public static void Main(){
      CC bike = new CC();
      Console.WriteLine("Bike : {0} {1} {2}",bike.CompanyName(),bike.TType(),bike.CCC());
    }
  } 
}


using System;


public interface Winner{
  string RCB();
}
public interface Loser{
  string CSK();
}
public class ESCN:Winner,Loser{
  public string RCB(){
    return "RCB";
  }
  public string CSK(){
    return "CSK";
  }
}
public class myInt{
  public static void Main(){
    ESCN eesalacupnamde = new ESCN();
    Console.WriteLine("Winners : {0} \n Losers : {1} \n EESalaCupNamde", eesalacupnamde.RCB(), eesalacupnamde.CSK());
  }
}