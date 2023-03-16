using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQueue.Library;

public class myQueue
{
    public bool empty;
    private List<int> _queue;
    public myQueue()
    {
        empty = true;
        _queue = new List<int>();
    }

    public int Dequeue()
    {
        empty = true;
        return _queue[0];
    }

    public void Enqueue(int item)
    {
        _queue.Add(item);
        empty = false;
    }

    public bool IsEmpty()
    {
        return empty;
    }

    public int Peek()
    {
        if (empty)
        {
            return -1;
        }
        return _queue[0];
    }
}
