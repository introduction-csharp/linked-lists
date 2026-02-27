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


}
