using LinkedListIntroduction.Lib; 

namespace LinkedListIntroduction.Tests;

[TestClass]
public sealed class BasicLinkedListTests
{

    [TestMethod]
    public void TestEmpty()
    {
        IntegerLinkedList ill = new IntegerLinkedList();
        Assert.AreEqual(0, ill.Count);
    }

    [TestMethod]
    public void TestCount()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.AreEqual(3, ill.Count);
    }

    [TestMethod]
    public void TestSum()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.AreEqual(21, ill.Sum);
    }

    [TestMethod]
    public void TestToStringExplicit()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.AreEqual("{5, 7, 9}", ill.ToString());
    }

    [TestMethod]
    public void TestPrepend()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        ill.Prepend(3);
        Assert.AreEqual("{3, 5, 7, 9}", ill.ToString());
    }
    [TestMethod]
    public void TestPrepend2()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        ill.Prepend2(3);
        Assert.AreEqual("{3, 5, 7, 9}", ill.ToString());
    }

    [TestMethod]
    public void TestDeleteWhenPresent()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.IsTrue(ill.Delete(7));
        Assert.AreEqual("{5, 9}", ill.ToString());
    }

    [TestMethod]
    public void TestDeleteHead()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.IsTrue(ill.Delete(5));
        Assert.AreEqual("{7, 9}", ill.ToString());
    }

    [TestMethod]
    public void TestDeleteWhenNotPresent()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.IsFalse(ill.Delete(6));
        Assert.AreEqual("{5, 7, 9}", ill.ToString());
    }

    [TestMethod]
    public void TestInserts()
    {
        var ill = new IntegerLinkedList(5);
        ill.Append(7);
        ill.Append(9);
        Assert.IsTrue(ill.Insert(8, 0));
        Assert.AreEqual("{8, 5, 7, 9}", ill.ToString());
        Assert.IsTrue(ill.Insert(8, 3));
        Assert.AreEqual("{8, 5, 7, 8, 9}", ill.ToString());
        Assert.IsFalse(ill.Insert(8, 94));
    }

    [TestMethod]
    public void TestListInitialisation()
    {
        var ill = new IntegerLinkedList([5,7,9]);
        Assert.AreEqual("{5, 7, 9}", ill.ToString());
    }

    [TestMethod]
    public void TestJoin()
    {
        var ill = new IntegerLinkedList([5,7,9]);
        var ill2 = new IntegerLinkedList([11,13,17]);
        ill.Join(ill2);
        Assert.AreEqual("{5, 7, 9, 11, 13, 17}", ill.ToString());
    }

    [TestMethod]
    public void TestReverse()
    {
        var ill = new IntegerLinkedList([5,7,9]);
        var ill2 = ill.Reverse();
        Assert.AreEqual("{9, 7, 5}", ill2.ToString());
    }

    [TestMethod]
    public void TestContains()
    {
        var ill = new IntegerLinkedList([5,7,3,9]);
        Assert.IsTrue(ill.Contains(5));
        Assert.IsTrue(ill.Contains(3));
        Assert.IsTrue(ill.Contains(9));
        Assert.IsFalse(ill.Contains(4));
    }

    [TestMethod]
    public void TestRemoveDuplicates()
    {
        var ill = new IntegerLinkedList([5,7,5,7,7,9,11,3,5,11]);
        ill.RemoveDuplicates();
        Assert.AreEqual("{5, 7, 9, 11, 3}", ill.ToString());
    }

    [TestMethod]
    public void TestMerge()
    {
        IntegerLinkedList ill1 = new([1,2,3]);
        IntegerLinkedList ill2 = new([4,5,6]);

        IntegerLinkedList ill3 = ill1.Merge(ill2);

        Assert.AreEqual(6, ill3.Count);
        Assert.AreEqual("{1, 4, 2, 5, 3, 6}", ill3.ToString());

        
    }
}
