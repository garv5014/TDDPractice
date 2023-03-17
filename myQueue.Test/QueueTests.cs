namespace myQueue.Test;

using FluentAssertions;
using myQueue.Library;
public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void IsEmptyOnCreation()
    {
        var queue = new myQueue(10);
        Assert.IsTrue(queue.IsEmpty());
    }

    [Test]
    public void IsNotEmptyOneEnqueue()
    {
        var queue = new myQueue(10);
        queue.Enqueue(2);
        Assert.IsFalse(queue.IsEmpty());
    }

    [Test]
    public void IsEmptyAfterEnqueueDequeue()
    {
        var queue = new myQueue(10);
        queue.Enqueue(2);
        queue.Dequeue();
        Assert.IsTrue(queue.IsEmpty());
    }

    [Test]
    public void IsNotEmptyAfterTwoEnqueueOneDequeue()
    {
        var queue = new myQueue(10);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Dequeue();
        Assert.IsFalse(queue.IsEmpty());
    }

    [Test]
    public void CanPeekFirstItem()
    { 
        var queue = new myQueue(10);
        queue.Enqueue(2);
        Assert.IsTrue(2 == queue.Peek());
    }

    [Test]
    public void FirstItemStaysTheSameAfterTwoEnqueues()
    {
        var queue = new myQueue(10);
        queue.Enqueue(3);
        queue.Enqueue(2);
        queue.Peek().Should().Be(3);
    }

    [Test]
    public void DequeueReturnsFirstItem()
    {
        var queue = new myQueue(10);
        queue.Enqueue(3);
        queue.Dequeue().Should().Be(3);
    }
}