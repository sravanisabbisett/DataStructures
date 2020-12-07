using Datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackAndQueue
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Pushes the element in stack.
        /// </summary>
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
        /// <summary>
        /// Pops the first element.
        /// </summary>
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

        /// <summary>
        /// Emptyings the stack.
        /// </summary>
        [TestMethod]
        public void EmptyingTheStack()
        {
            Stack stack = new Stack();
            int myFirstElement = 70;
            int mySecondElement = 30;
            int myThirdElement = 56;
            stack.Push(myFirstElement);
            stack.Push(mySecondElement);
            stack.Push(myThirdElement);
            stack.EmptyingTheStack();
            int size = stack.Size();
            Assert.AreEqual(0, size);
        }

        /// <summary>
        /// Checks the stack is empty.
        /// </summary>
        [TestMethod]
        public void CheckStackIsEmpty()
        {
            Stack stack = new Stack();
            int myFirstElement = 70;
            int mySecondElement = 30;
            int myThirdElement = 56;
            stack.Push(myFirstElement);
            stack.Push(mySecondElement);
            stack.Push(myThirdElement);
            stack.EmptyingTheStack();
            bool result = stack.IsEmpty();
            Assert.IsTrue(result);
        }
    }
}

