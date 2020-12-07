using Datastructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LinkedListTest
{
    [TestClass]
    public class UnitTest1
    {

        LinkedList linkedList; 

        public UnitTest1()
        {
            linkedList = new LinkedList();
        }
        /// <summary>
        /// UC1 Given3s the numbers when added to linked list should be add at top.
        /// </summary>
        [TestMethod]
        public void Given3NumbersWhenAddedToLinkedListShouldBeAddAtTop()
        {
            int myFirstNode = 70;
            int mySecndNode = 30;
            int myThirdNode = 56;

            linkedList.add(70);
            linkedList.add(30);
            linkedList.add(56);
            int firstNode = linkedList.CheckFirstElement();
            int secondNode = linkedList.CheckMiddleElement();
            int thirdNode = linkedList.CheckLastElement();
            bool result = firstNode.Equals(myThirdNode) && secondNode.Equals(mySecndNode) && thirdNode.Equals(myFirstNode);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// UC2 Givens the three numbers to linked list should be added at last.
        /// </summary>
        [TestMethod]
        public void GivenThreeNumbersToLinkedListShouldBeAddedAtLast()
        {
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 70;

            linkedList.append(myFirstNode);
            linkedList.append(mySecondNode);
            linkedList.append(myThirdNode);
            int firstNode = linkedList.CheckFirstElement();
            int secondNode = linkedList.CheckMiddleElement();
            int thirdNode = linkedList.CheckLastElement();

            bool result= firstNode.Equals(myFirstNode) && secondNode.Equals(mySecondNode) && thirdNode.Equals(myThirdNode);
            Assert.IsTrue(result);
        }

    }
}
