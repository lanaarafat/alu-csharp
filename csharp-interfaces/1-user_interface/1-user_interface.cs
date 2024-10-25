using System;

/// <summary>
/// Base abstract class.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name of the object.
    /// </summary>
    public string ? name {get; set;}

    /// <summary>
    /// Provides a string representation of the object.
    /// </summary>
    /// <returns>String in the format: "name is a [type]"</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
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
        int durability{get; set; }
        void Break();

    }

    public interface ICollectable
    {
        /// <summary>
        /// ICollectable
        /// </summary>
        bool isCollectable{get; set; }
        void Collect();
    }
}

public class TestObject : Base, IInteractive, IBreakable, ICollectable {
    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact() {

    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Break() {

    }

    /// <summary>
    /// Durability implementation
    /// </summary>
    public int durability {
        get {return durability;}
        set {durability = value;}
    }

    /// <summary>
    /// Collect implementation
    /// </summary>
    public void Collect() {

    }

    /// <summary>
    /// Collect Implementation
    /// </summary>
    public bool isCollected {
        get {return isCollected;}
        set {isCollected = value;}
    }
}