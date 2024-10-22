using System;
/// <summary>
/// abstract class
/// </summary>

public abstract class Base
{
    /// <summary>
    /// abstract class
    /// </summary>
    public string name;
    /// <summary>
    /// empty
    /// </summary>
    /// <returns></returns>
    public override string Tostring()
    {
        /// <summary>ToString</summary>
        return($"{name} is a {this.GetType()}");
    }

    public interface IInteractive
    {
        /// <summary>
        /// IInteractive
        /// </summary>
        void Interact();
    }

    public interface IBreakable
    {
        /// <summary>
        /// IBreakable
        /// </summary>
        int durability{get; set; };
        void Break();

    }

    public interface ICollectable
    {
        /// <summary>
        /// ICollectable
        /// </summary>
        bool isCollectable{get; set; };
        void Collect();
    }
}

public class Door : Base, IInteractive
{
    /// <summary>
    /// class Door
    /// </summary>
    /// <param name="name"></param>
    public Door(string name = "Door")
    {
        /// <summary>ToString</summary>
        this.name = name;
    }
    public void Interact()
    {
        /// <summary>ToString</summary>
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>This is Interact.</summary>
    public int durability{ get; set; }
    /// <summary>This is Interact.</summary>
    public bool isQuestItem;

    /// <summary>This is Interact.</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    public void Interact()
    {
        if (durablility <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestion == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside");

        }
        else (isQuestion == false)
        {
            console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    public void Break()
    {
        durability--;
        if (durablility > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.")
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");

        }
        else (durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }

    public class Key : Base, ICollectable
    {
        public bool isCollected{get; set;}
        public  Key(string name = "Key", bool isCollectable = false)
        {
            this.name = name;
            this isCollectable = isCollectable;
        }

        public void Collect()
        {
            if (isCollected == false)
            {
                isCollected = true;
                Console.WriteLine($"You pick the {name}.");
            }

            else (isCollected == true)
            {
                Console.WriteLine($"You already picked up the {name}.");
            }
        }
    }
}
