namespace CustomLinkedList.Tests
{
    using System;
    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DYnamicListTests
    {
        private DynamicList<int> listWithIntegers;
        private DynamicList<string> listWithStrings;

        [TestInitialize]
        public void InitList()
        {
            this.listWithIntegers = new DynamicList<int>();
            this.listWithStrings = new DynamicList<string>();
        }

        [TestMethod]
        public void CreatedEmptyListShouldHaveCountZero()
        {
            Assert.AreEqual(0, this.listWithIntegers.Count, "The elements count is not equal to zero.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetInvalidIndex()
        {
            var element = this.listWithIntegers[0];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetAtInvalidIndex()
        {
            this.listWithIntegers[0] = 1;
        }

        [TestMethod]
        public void TestAddingOneElement()
        {
            this.listWithIntegers.Add(1);

            Assert.AreEqual(1, this.listWithIntegers[0], "Element is not added to list.");
        }

        [TestMethod]
        public void ElementsCountShouldIncreaseAfterAddingElements()
        {
            this.listWithIntegers.Add(50);
            this.listWithIntegers.Add(60);

            Assert.AreEqual(
                2, 
                this.listWithIntegers.Count, 
                "Elements counter does not increment after element is added");
        }

        [TestMethod]
        public void TestSettingAnElementAtIndex()
        {
            this.listWithIntegers.Add(1);
            this.listWithIntegers[0] = 2;

            Assert.AreEqual(2, this.listWithIntegers[0], "Element is not added to list.");
        }

        [TestMethod]
        public void TestRemoveAtMethod()
        {
            this.listWithIntegers.Add(10);
            this.listWithIntegers.Add(20);
            this.listWithIntegers.RemoveAt(0);

            Assert.AreEqual(
                20, 
                this.listWithIntegers[0], 
                "RemoveAt() does not remove the element at the correct index");
        }

        [TestMethod]
        public void RemoveAtMethodShouldReturnElementAfterRemovingIt()
        {
            this.listWithIntegers.Add(10);
            var element = this.listWithIntegers.RemoveAt(0);

            Assert.AreEqual(10, element, "RemoveAt() does not return element.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtMethodWithInvalidIndex()
        {
            this.listWithIntegers.Add(1);
            this.listWithIntegers.RemoveAt(1);
        }

        [TestMethod]
        public void RemoveAtMethodShouldDecrementElementCount()
        {
            this.listWithIntegers.Add(1);
            this.listWithIntegers.RemoveAt(0);

            Assert.AreEqual(
                0, 
                this.listWithIntegers.Count, 
                "The element counter is not decremented after element is removed with RemoveAt().");
        }

        [TestMethod]
        public void TestRemoveWithAnInteger()
        {
            this.listWithIntegers.Add(10);
            this.listWithIntegers.Add(20);
            this.listWithIntegers.Remove(10);

            Assert.AreEqual(
                20, 
                this.listWithIntegers[0], 
                "The Remove() method does not remove the requested item.");
        }

        [TestMethod]
        public void TestRemoveWithAString()
        {
            this.listWithStrings.Add("First");
            this.listWithStrings.Add("Second");
            this.listWithStrings.Remove("First");

            Assert.AreEqual(
                "Second", 
                this.listWithStrings[0],
                "The Remove() method does not remove the requested item.");
        }

        [TestMethod]
        public void RemoveMethodShouldDecrementElementCount()
        {
            this.listWithIntegers.Add(10);
            this.listWithIntegers.Add(20);
            this.listWithIntegers.Remove(10);

            Assert.AreEqual(
                1, 
                this.listWithIntegers.Count,
                "The element count is not decremented after an element is removed with Remove() method.");
        }

        [TestMethod]
        public void RemoveMethodShouldReturnIndexOfRemovedElement()
        {
            this.listWithIntegers.Add(10);
            this.listWithIntegers.Add(20);
            var index = this.listWithIntegers.Remove(20);

            Assert.AreEqual(
                1, 
                index,
                "Remove() method does not return the correct index of the removed item.");
        }

        [TestMethod]
        public void RemoveMethodShouldReturnMinusOneIfElementNotFound()
        {
            this.listWithIntegers.Add(10);
            var index = this.listWithIntegers.Remove(20);

            Assert.AreEqual(
                -1, 
                index,
                "Remove() method does not return -1 when element not found.");
        }

        [TestMethod]
        public void MethodIndexOfShouldReturnCorrectIndexOfItem()
        {
            this.listWithIntegers.Add(10);
            var index = this.listWithIntegers.IndexOf(10);

            Assert.AreEqual(
                0, 
                index,
                "IndexOf() method does not return the correct index.");
        }

        [TestMethod]
        public void MethodIndexOfShouldReturnMinusOneIfItemNotFound()
        {
            this.listWithIntegers.Add(10);
            var index = this.listWithIntegers.IndexOf(20);

            Assert.AreEqual(
                -1, 
                index,
                "IndexOf() method does not return the correct index.");
        }

        [TestMethod]
        public void TestIndexOfWithString()
        {
            this.listWithStrings.Add("Zero");
            this.listWithStrings.Add("One");
            var index = this.listWithStrings.IndexOf("One");

            Assert.AreEqual(1, index, "IndexOf() method does not return the correct index when using a string");
        }

        [TestMethod]
        public void TestContainsWithAnInteger()
        {
            this.listWithIntegers.Add(10);
            bool contains = this.listWithIntegers.Contains(10);

            Assert.IsTrue(contains, "The Contains() method does not find the searched for element");
        }

        [TestMethod]
        public void TestContainsWithAString()
        {
            this.listWithStrings.Add("Hello");
            bool contains = this.listWithStrings.Contains("Hello");

            Assert.IsTrue(contains, "The Contains() method does not find the searched for element");
        }

        [TestMethod]
        public void TestContainsWhenElementIsNotInList()
        {
            this.listWithIntegers.Add(10);
            bool contains = this.listWithIntegers.Contains(20);

            Assert.IsFalse(contains, "The Contains() method does not return false when element is not in list.");
        }

        [TestMethod]
        public void AddOneHundredElementsToList()
        {
            for (int i = 0; i < 100; i++)
            {
                this.listWithIntegers.Add(i);
            }
            
            Assert.AreEqual(99, this.listWithIntegers[this.listWithIntegers.Count - 1], "aaa");
        }
    }
}