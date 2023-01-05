using System;

class TVS
{
    public virtual void Bike(){
    	Console.WriteLine("TVS - I'm heavy Duty");
    }
}

class KTM : TVS
{
    public override void Bike(){
    	Console.WriteLine("KTM RC390 - Ready to Race");
    }
}
class Bike
{
 static void Main()
 {
    TVS d = new TVS();
    d.Bike();
    
    d = new KTM();
    d.Bike();
 }
}