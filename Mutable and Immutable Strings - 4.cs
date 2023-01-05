using System;
using System.Text;
namespace str{
  class str{
    public static void Main(){
      string s = "Jane";
      string s2 = s.Replace('J','K');
      string s3 = s2.Replace('n','t');

      Console.WriteLine(s);
      Console.WriteLine(s3);

      StringBuilder sb = new StringBuilder("Jane");
      Console.WriteLine(sb);
      sb.Replace('J', 'K', 0, 1);
      sb.Replace('n', 't', 2, 1);

      Console.WriteLine(sb);
    }
  }
}