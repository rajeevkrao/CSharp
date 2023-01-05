using System;

namespace ErrorHandlingApplication {
   class Bounds:Exception{
      public static void Main(){
         int[] a = {1,2,3,4,5};
         try{
            Console.WriteLine(a[8]);
         }
         catch(IndexOutOfRangeException e){
            Console.WriteLine("Exception has occured : "+e.Message);
         }
      }
   }
}