using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQueue.Library;

public class myQueue
{
    private int[] _queue;
    private int _head; 
    private int _tail;
    public int Count { get; private set; }
    public myQueue(int size = 10)
    {
        _queue = new int[size];
        _head = 0;
        _tail = 0;
        Count= 0;
    }

    public int Dequeue()
    {
        var firstItem = _queue[_head];
        Count--;
        return firstItem;
    }

    public void Enqueue(int item)
    {
        _queue[_tail] = item;
        _tail++;
        Count++;
    }

    public bool IsEmpty()
    {
        return (Count == 0);
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            return -1;
        }
        return _queue[0];
    }
}
