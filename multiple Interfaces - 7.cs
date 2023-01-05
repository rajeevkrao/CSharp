using System;

namespace Interfaces{
	public interface color{
		string red();
	}
	public interface shape{
		string cube();
	}
	public class rubiks:color,shape{
		public string red(){
			return "#ff0000";
		}
		public string cube(){
			return "3x3x3";
		}
	}
	class myInt{
		public static void Main(){
			rubiks obj = new rubiks();
			Console.WriteLine("Object's Shape : {0} and Color : {1}", obj.cube(), obj.red());
		}
	}
}