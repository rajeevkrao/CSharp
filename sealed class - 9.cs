using System;   

sealed class KTM { 
  
    public string bodyType() 
    { 
        return "Bike";
    } 
} 
/*
class KIA : KTM {
    public string bodyType(){
        return "Car";
    }
}
*/
class Program { 
  

    static void Main(string[] args) 
    { 
        KTM veh = new KTM();
        Console.WriteLine("Riding {0}",veh.bodyType());
        //KIA vehi = new KIA();
        //Console.WriteLine("Driving {0}",vehi.bodyType());
    } 
}