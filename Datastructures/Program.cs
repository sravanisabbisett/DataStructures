﻿using System;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 40;
            int myFourthNode = 70;
            linkedList.Append(myFirstNode);
            linkedList.Append(mySecondNode);
            linkedList.Append(myFourthNode);
            linkedList.Insert(3, myThirdNode);
            linkedList.Display();
            Console.WriteLine("size:" + linkedList.Size());
            Console.ReadKey();
        }
    }
}
