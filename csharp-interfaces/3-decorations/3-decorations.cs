using System;

/// <summary>
/// Base abstract class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public string? name { get; set; }

    /// <summary>
    /// Provides a string representation of the object.
    /// </summary>
    /// <returns>String in the format: "name is a [type]"</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// IInteractive interface.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact with the object.
    /// </summary>
    void Interact();
}

/// <summary>
/// IBreakable interface.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break the object.
    /// </summary>
    void Break();
}

/// <summary>
/// ICollectable interface.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets whether the object is collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect the object.
    /// </summary>
    void Collect();
}

/// <summary>
/// Represents a Door that can be interacted with.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the Door class.
    /// </summary>
    /// <param name="name">The name of the door.</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interacts with the Door, attempting to open it.
    /// </summary>
    public void Interact()
    {
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
            console.WriteLine($"The {name} is already broken.")
        }
    }
}
