namespace myQueue.Test;
using myQueue.Library;
using System.Collections;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void IsEmptyOnCreation()
    {
        var queue = new myQueue();
        Assert.IsTrue(queue.IsEmpty());
    }

    [Test]
    public void IsNotEmptyOneEnqueue()
    {
        var queue = new myQueue();
        queue.Enqueue(2);
        Assert.IsFalse(queue.IsEmpty());
    }

    [Test]
    public void IsEmptyAfterEnqueueDequeue()
    {
        var queue = new myQueue();
        queue.Enqueue(2);
        queue.Dequeue();
        Assert.IsTrue(queue.IsEmpty());
    }

    [Test]
    public void CanPeekFirstItem()
    { 
        var queue = new myQueue();
        queue.Enqueue(2);
        Assert.IsTrue(2 == queue.Peek());
    }

    [Test]
    public void FirstItemStaysTheSameAfterTwoEnqueues()
    {
        var queue = new myQueue();
        queue.Enqueue(3);
        queue.Enqueue(2);
        Assert.IsTrue(3 == queue.Peek());
    }
}