using System;
namespace a{
    class Indexer{
        private string[] val = new string(3);
        public string this[int index]
        {
            get{
                return val[index];
            }
            set{
                val[index] = value;
            }
        }
        public static void Main(){
            Indexer ic = new Indexer();
            ic[0]="Y";
            ic[1]="Yash";
            ic[2]="Yashwanth";
            Console.WriteLine("values stored in Objects used as array");
            Console.WriteLine(ic[0]);
            Console.WriteLine(ic[1]);
            Console.WriteLine(ic[2]);
        }
    }
}