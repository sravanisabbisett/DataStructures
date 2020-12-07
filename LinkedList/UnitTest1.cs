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
        /// UC2 Given3s the numbers when added to linked list should be add at top.
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
            bool result=linkedList.head.data.Equals(myThirdNode) && linkedList.head.next.data.Equals(mySecndNode) 
                                                                    && linkedList.tail.data.Equals(myFirstNode);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// UC3 Givens the three numbers to linked list should be added at last.
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
            bool result = linkedList.head.data.Equals(myFirstNode) && linkedList.head.next.data.Equals(mySecondNode) 
                                                                    && linkedList.tail.data.Equals(myThirdNode);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// UC4 Adds the two element and insert at middle.
        /// </summary>
        [TestMethod]
        public void AddTwoElementAndInsertNewElementAtMiddle()
        {
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 70;

            linkedList.append(myFirstNode);
            linkedList.append(myThirdNode);
            linkedList.Insert(2, mySecondNode);
            bool result = linkedList.head.data.Equals(myFirstNode) && linkedList.head.next.data.Equals(mySecondNode)
                                                                    && linkedList.tail.data.Equals(myThirdNode);

            Assert.IsTrue(result);
        }

        /// <summary>
        /// UC5 Removes the first element inthe list.
        /// </summary>
        [TestMethod]
        public void RemoveFirstElementIntheList()
        {
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 70;
            linkedList.append(myFirstNode);
            linkedList.append(mySecondNode);
            linkedList.append(myThirdNode);
            linkedList.pop();
            bool result = linkedList.head.data.Equals(mySecondNode);
            Assert.IsTrue(result);
        
        }

        /// <summary>
        /// UC6 Removes the last element in the list.
        /// </summary>
        [TestMethod]
        public void RemoveLastElementInTheList()
        {
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 70;
            linkedList.append(myFirstNode);
            linkedList.append(mySecondNode);
            linkedList.append(myThirdNode);
            linkedList.PopLast();
            bool result = linkedList.tail.data.Equals(mySecondNode);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Searches the element in the list.
        /// </summary>
        [TestMethod]
        public void SearchElementinTheList()
        { 
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 70;
            linkedList.append(myFirstNode);
            linkedList.append(mySecondNode);
            linkedList.append(myThirdNode);
            int searchElement=linkedList.search(mySecondNode);
            Assert.AreEqual(mySecondNode, searchElement);
        }

        /// <summary>
        /// Inserts the in middle.
        /// </summary>
        [TestMethod]
        public void InsertInmiddle()
        {
            int myFirstNode = 56;
            int mySecondNode = 30;
            int myThirdNode = 40;
            int myFourthNode = 70;
            linkedList.append(myFirstNode);
            linkedList.append(mySecondNode);
            linkedList.append(myFourthNode);
            linkedList.Insert(3, myThirdNode);
            int searchResult = linkedList.search(myThirdNode);
            Assert.AreEqual(myThirdNode, searchResult);
        }

    }
}
