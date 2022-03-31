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
    }
    
}