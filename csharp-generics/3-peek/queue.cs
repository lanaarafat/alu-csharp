using System;

public class Queue<T>
{
    public Type CheckType()
    {
        return (typeof(T));
    }

    public class Node
    {
        public T value = null;

        public Node next = null;

        public Node(T var)
        {
            value = var;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    public void Enqueue(T var)
    {
        Node newNode = new Node(var);

        if (head == null)
        {
            head = newNode;
            tail = newNode;

        }

        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public void Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));

            Node value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    public void peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        return(head.value);
    }

    public int Count()
    {
        return(count);
    }

    
}