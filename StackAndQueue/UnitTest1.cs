using Datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackAndQueue
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PushElementInStack()
        {
            Stack stack = new Stack();
            int myFirstElement = 70;
            int mySecondElement = 30;
            int myThirdElement = 56;
            stack.Push(myFirstElement);
            stack.Push(mySecondElement);
            stack.Push(myThirdElement);
            int peek = stack.Peek();
            Assert.AreEqual(myThirdElement, peek);
        }

        [TestMethod]
        public void PopTheFirstElement()
        {
            Stack stack = new Stack();
            int myFirstElement = 70;
            int mySecondElement = 30;
            int myThirdElement = 56;
            stack.Push(myFirstElement);
            stack.Push(mySecondElement);
            stack.Push(myThirdElement);
            stack.Pop();
            int peek = stack.Peek();
            Assert.AreEqual(mySecondElement, peek);
        }
    }
}

