/// <summary>
/// Concatenates all values in the queue if the queue type is string or char.
/// </summary>
/// <returns>
/// Returns a concatenated string if the queue type is string or char, otherwise returns null.
/// If the queue is empty, prints a message and returns null.
/// If the queue type is neither string nor char, prints a message and returns null.
/// </returns>
public class Queue<T>
{
    /// <summary>
    /// This is Queue empty class.
    /// </summary>
    public Type CheckType()
    {
        return(typeof(T));
    }

    /// <summary>
    /// This is Queue empty class.
    /// </summary>
    public class Node
    {
        /// <summary>This is Queue empty class.</summary>
        public T value = default(T);
        /// <summary>This is Queue empty class.</summary>
        public Node next = null;

        /// <summary>This is Queue empty class.</summary>
        public Node(T var)
        {
            value = var;
        }
    }

    /// <summary>This is Queue empty class.</summary>
    public Node head = null;
    /// <summary>This is Queue empty class.</summary>
    public Node tail = null;
    /// <summary>This is Queue empty class.</summary>
    public int count;

    /// <summary>This is Queue empty class.</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
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
    /// <summary>This is Queue empty class.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }

        Node tmp = head;
        head = head.next;
        count--;
        return(tmp.value);
    }

    /// <summary>This is Queue empty class.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }

        return(head.value);
    }
    /// <summary>This is Queue empty class.</summary>
    public void Print()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        else
        {
            Node tmp = head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.value);
                tmp = tmp.next;
            }
        }
    }
    public T Concatenate()
    {
        // Check if the queue is empty
        if (head == null)
        {
            // Print message if queue is empty and return null
            Console.WriteLine("Queue is empty");
            return default(T);  // Return null for reference types like String or Char.
        }

        // Check if the queue is of type string
        if (CheckType() == typeof(string))
        {
            // Initialize a temporary node to traverse the queue
            Node tmp = head;
            string result = "";

            // Loop through all nodes in the queue and concatenate the values
            while (tmp != null)
            {
                result += tmp.value;  // Append the value of each node to the result string
                tmp = tmp.next;  // Move to the next node
            }

            // Return the concatenated string
            return (T)(object)result;  
        }

        // Check if the queue is of type char
        else if (CheckType() == typeof(char))
        {
            // Initialize a temporary node to traverse the queue
            Node tmp = head;
            string result = "";

            // Loop through all nodes in the queue and concatenate the char values
            while (tmp != null)
            {
                result += tmp.value.ToString();  // Append each char value to the result string
                tmp = tmp.next;  // Move to the next node
            }

            // Return the concatenated chars as a string
            return (T)(object)result;  
        }

        // If the queue type is neither string nor char
        else
        {
            // Print message indicating invalid type for concatenation and return null
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return default(T);  // Return null
        }
    }
}