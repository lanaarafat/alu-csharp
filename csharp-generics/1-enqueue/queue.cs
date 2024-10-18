using System;
/// <summary>
/// xml
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>
{
    /// <summary>
    /// xml
    /// </summary>
    /// <returns></returns>
    public Type CheckType()
    {
        return(typeof(T));
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

    public int Count()
    {
        return(count);
    }
}