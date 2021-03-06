using NUnit.Framework;
using System.Collections;
using LinkedList;
using LinkedListTest.LinkedListTestSource;
using System;

namespace LinkedListTests
{
    public class Tests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, LList list, LList expectedList)
        {
            list.Add(value);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest (int value, LList list, LList expectedList)
        {
            list.AddFirst(value);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int value, int index, LList list, LList expectedList)
        {
            list.AddByIndex(value, index);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(TheListIsEmptyTestSource))]
        public void AddByIndex_WhenListIsEmpty_ShouldExceptionTheListIsEmptyTest(int value, int index, LList list)
        {
            Assert.Throws<Exception>(() => list.AddByIndex(value, index));
        }

        [TestCaseSource(typeof(TheIndexOutOfRangeTestSource))]
        public void AddByIndex_WhenIndexOutOfRange_ShouldExceptionOutOfRangeTest(int value, int index, LList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddByIndex(value, index));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(LList list, LList expectedList)
        {
            list.DeleteLast();
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        
        [Test]
        public void DeleteLast_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(()=>list.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(LList list, LList expectedList)
        {
            list.DeleteFirst();
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        
        [Test]
        public void DeleteFirst_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, LList list, LList expectedList)
        {
            list.DeleteByIndex(index);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(TheListIsEmptyWithIndexTestSource))]
        public void DeleteByIndex_WhenListIsEmpty_ShouldExceptionTest(int index, LList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(TheIndexOutOfRangeWithIndexTestSource))]
        public void DeleteByIndex_WhenIndexDoesNotExist_ShouldExceptionOutOFRangeTest(int index, LList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteFewLastElementsTestSource))]
        public void DeleteFewLastElementsTest(int amount, LList list, LList expectedList)
        {
            list.DeleteFewLastElements(amount);
            LList actualList = list;
            Assert.AreEqual(expectedList,actualList);
        }

        [TestCaseSource(typeof(WhenListIsEmptyWithAmountTestSource))]
        public void DeleteFewLastElements_WhenListIsEmpty_ShouldExceptionTest (int amount, LList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFewLastElements(amount));  
        }
        
        [TestCaseSource(typeof(WhenAmountMoreOrLessThenLengthTestSource))]
        public void DleteFewLastElements_WhenAmountMoreOrLessThenLength_ShouldExceptionTest(int amount, LList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>list.DeleteFewLastElements(amount)); 
        }

        [TestCaseSource(typeof(DeleteFewFirstElementsTestSource))]
        public void DeleteFewFirstElementsTest(int amount, LList list, LList excpectedList)
        {
            list.DeleteFewFirstElements(amount);
            LList actualList = list;
            Assert.AreEqual(excpectedList,actualList);
        }

        [TestCaseSource(typeof(WhenListIsEmptyWithAmountTestSource))]
        public void DeleteFewFirstElements_WhenListIsEmpty_ShouldExceptionTest(int amount, LList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFewFirstElements(amount));
        }

        [TestCaseSource(typeof(WhenAmountMoreOrLessThenLengthTestSource))]
        public void DleteFewFirstElements_WhenAmountMoreOrLessThenLength_ShouldExceptionTest(int amount, LList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteFewFirstElements(amount));
        }

        [TestCaseSource(typeof(DeleteFewElementsByIndexTestSource))]
        public void DeleteFewElementsByIndexTest(int index, int amount, LList list, LList expectedList)
        {
            list.DeleteFewElementsByIndex(index, amount);
            LList actualList=list;
            Assert.AreEqual(expectedList,actualList);
        }

        [TestCaseSource(typeof(WhenListIsEmptyWithAmountAndIndexTestSource))]
        public void DeleteFewElementsByIndex_WhenListIsEmpty_ShouldExceptionTest(int index, int amount, LList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFewElementsByIndex(index, amount));
        }

        [TestCaseSource(typeof(WhenAmountMoreOrLessThenLengthWithIndexTestSource))]
        public void DeleteFewElementsByIndex_WhenAmountOutOfRange_ShouldExceptionTest(int index, int amount, LList list)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => list.DeleteFewElementsByIndex(index,amount));
        }

        [TestCaseSource(typeof(WhenIndexOutOfRangeWithAmountTestSource))]
        public void DeleteFewElementsByIndex_WhenIndexOutOfRange_ShouldExceptionTest(int index, int amount, LList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteFewElementsByIndex(index, amount));
        }

        [TestCaseSource(typeof(GetByIndexTestSource))]
        public void GetByIndexTest(int index, LList list, int expectedValue)
        {
            int actualValue=list[index];
            Assert.AreEqual(expectedValue,actualValue);

        }

        [TestCaseSource(typeof(SetByIndexTestSource))]
        public void SetByIndexTest(int index, int value, LList list, LList expectedList)
        {
            list[index] = value;
            LList actualList = list;
            Assert.AreEqual(expectedList,actualList);
            
        }
        
        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest(int value, LList list, int excpectedIndex)
        {
            int actualIndex= list.FindFirstIndexByValue(value);
            Assert.AreEqual(excpectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(WhenListIsEmptyWithAmountTestSource))]
        public void FindFirstIndexByValue_WhenListIsEmpty_ShouldException(int value, LList list)
        {
            Assert.Throws<Exception>(() => list.FindFirstIndexByValue(value));
        }

        [TestCaseSource(typeof(FindMaxValueTestSource))]
        public void FindMaxValueTest(LList list, int expectedMaxValue)
        {
            int actualMaxValue = list.FindMaxValue();
            Assert.AreEqual(expectedMaxValue,actualMaxValue);
        }

        [Test]
        public void FindMaxValue_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(() => list.FindMaxValue());
        }

        [TestCaseSource(typeof(FindMinValueTestSource))]
        public void FindMinValueTest(LList list, int expectedMinValue)
        {
            int actualMinValue = list.FindMinValue();
            Assert.AreEqual(expectedMinValue, actualMinValue);
        }

        [Test]
        public void FindMinValue_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(() => list.FindMinValue());
        }

        [TestCaseSource(typeof(FindIndexOfMinValueTestSource))]
        public void FindIndexOfMinValueTest(LList list, int expectedIndex)
        {
            int actualIndex = list.FindIndexOfMinValue();
            Assert.AreEqual(expectedIndex,actualIndex);
        }

        [Test]
        public void FindIndexOfMinValue_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(() => list.FindIndexOfMinValue());
        }

        [TestCaseSource(typeof(FindIndexOfMaxValueTestSource))]
        public void FindIndexOfMaxValueTest(LList list, int expecetedIndex)
        {
            int actualIndex=list.FindIndexOfMaxValue();
            Assert.AreEqual(expecetedIndex,actualIndex);
        }

        [Test]
        public void FindIndexOfMaxValue_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(()=>list.FindIndexOfMaxValue());   
        }

        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, LList list, LList expectedList, int expectedIndex)
        {
            int actualIndex = list.DeleteFirstByValue(value);
            LList actualList = list;
            Assert.AreEqual(expectedIndex, actualIndex);
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(WhenListIsEmptyWithValueTestSource))]
        public void DeleteFirstByValue_WhenListIsEmpty_ShouldException(int value, LList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstByValue(value));
        }

        [TestCaseSource(typeof(DeleteEveryElementByValueTestSource))]
        public void DeleteEveryElementByValueTest(int value, LList list, LList expectedList, int expectedCount)
        {
            int actualCount = list.DeleteEveryElementByValue(value);
            list.DeleteEveryElementByValue(value);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void DeleteEveryElementByValue_WhenListIsEmpty_ShouldThrowExceptionTest()
        {
            LList list = new LList();
            int value = 5;
            Assert.Throws<Exception>(()=>list.DeleteEveryElementByValue(value));    
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(LList list, LList expectedList)
        {
            list.Reverse();
            LList actualList = list;
            Assert.AreEqual(expectedList,actualList);
        }

        [Test]
        public void Reverse_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(()=>list.Reverse());
        }

        [TestCaseSource(typeof(SortFromMintoMaxTestSource))]
        public void SortFromMintoMaxTest(LList list, LList expectedList)
        {
            list.SortFromMintoMax();
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        
        [Test]
        public void SortFromMintoMax_WhenListIsEmpty_ShouldThrowExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(() => list.SortFromMintoMax());
        }

        [TestCaseSource(typeof(SortFromMaxToMinTestSource))]
        public void SortFromMaxToMinTest(LList list, LList expectedList)
        {
            list.SortFromMaxToMin();
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [Test]
        public void SortFromMaxToMin_WhenListIsEmpty_ShouldExceptionTest()
        {
            LList list = new LList();
            Assert.Throws<Exception>(()=>list.SortFromMaxToMin());  
        }

        [TestCaseSource(typeof(AddListInTheEndTestSource))]
        public void AddListInTheEndTest(LList list, LList extraList, LList expectedList)
        {
            list.AddListInTheEnd(extraList);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListInTheStartTestSource))]
        public void AddListInTheStartTest(LList extraList, LList list, LList expectedList)
        {
            list.AddListInTheStart(extraList);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(LList extraList, int index, LList list, LList expectedList)
        {
            list.AddListByIndex(extraList, index);
            LList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        [Test]
        public void AddListByIndex_WhenListISEmpty_ShouldExceptionTest()
        {
            LList list= new LList();
            LList extraList = new LList();
            int index = 99;
            Assert.Throws<Exception>(()=>list.AddListByIndex(extraList, index));    
        }

        public void AddListByIndex_WhenIndexOutOfRangeTest()
        {
            LList list = new LList(new int[] {4,5,6});
            LList extraList = new LList(new int[] {8,7,9});
            int index = 99;
            Assert.Throws<IndexOutOfRangeException>(() => list.AddListByIndex(extraList, index));
        }

    }




    
    
}