using System;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.add(70);
            linkedList.add(30);
            linkedList.add(56);
            Console.WriteLine("Add the dat at top");
            linkedList.Display();
            Console.ReadKey();
        }
    }
}
