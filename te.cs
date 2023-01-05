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