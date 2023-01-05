using System;

namespace ArrayApplication {
   class MyArray {
      static void Main(string[] args) {
         int[][] a = new int[][]{
            new int[]{11,12,13,14,15},
            new int[]{2,5,7},
            new int[]{1,2}
         };
         int i, j;
  
         for (i = 0; i < a.Length; i++) {
            for (j = 0; j < a[i].Length; j++) {
               Console.Write("{0} ",a[i][j]);
            }
            Console.WriteLine();
         }
      }
   }
}