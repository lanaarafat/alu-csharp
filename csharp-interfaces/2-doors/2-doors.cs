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
        int durability { get; set; }
        void Break();

    }

    public interface ICollectable
    {
        /// <summary>
        /// ICollectable
        /// </summary>
        bool isCollectable { get; set; }
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
