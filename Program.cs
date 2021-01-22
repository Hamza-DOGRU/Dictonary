using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int,string> myDictonary =new MyDictonary<int,string>();
            myDictonary.Add(1,"Hamza");
            myDictonary.Add(2, "Özgür");
            myDictonary.Add(3, "Burak");
            Console.WriteLine(myDictonary.Count);
            
        }
    }
}
