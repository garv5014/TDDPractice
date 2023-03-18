namespace TDDProjects.Test;

using FluentAssertions;
public class QueueTests
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

    [Test]
    public void QueueDoesntAllowEnqueuWhenFull()
    {
        var queue = new myQueue(2);
        queue.Enqueue(3);
        queue.Enqueue(2);
        try
        {
            queue.Enqueue(1);
        }
        catch (Exception ex)
        {
            if (ex.Message == "Queue is full") { Assert.Pass(); }
            else { Assert.Fail(); }
        }
    }

    [Test]
    public void QueueThrowsAnExceptionWhenDequeueAndEmpty()
    {
        var queue = new myQueue(2);
        try
        {
            queue.Dequeue();
        }
        catch (Exception ex)
        {
            if (ex.Message == "Queue is empty") { Assert.Pass(); }
            else { Assert.Fail(); }
        }
    }

    [Test]
    public void QueueIsFilledThenOneItemRemovedAndFilledAgain()
    {
        int targetItem;
        var queue = new myQueue(2);
        queue.Enqueue(3);
        queue.Enqueue(2);
        try
        {
            targetItem = queue.Dequeue();
            queue.Enqueue(1);
        }
        catch (Exception e)
        {
            Assert.Fail();
            throw;
        }
        Assert.True(targetItem == 3);
    }

    [Test]
    public void DequeueOrderIsCorrect()
    {
        var queue = new myQueue(3);
        queue.Enqueue(3);
        queue.Enqueue(2);
        queue.Enqueue(1);
        queue.Dequeue().Should().Be(3);
        queue.Dequeue().Should().Be(2);
        queue.Dequeue().Should().Be(1);
        queue.Enqueue(3);
        queue.Dequeue().Should().Be(3);
        queue.IsEmpty().Should().BeTrue();
    }
}