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

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>Interact</summary>
    public int durability{get => throw new NotImplementableExpectation() ; set=> throw new NotImplementableException(); }
    /// <summary>Interact</summary>
    public bool isCollectable{get => throw new NotImplementableExpectation() ; set=> throw new NotImplementableException(); }
    /// <summary>Interact</summary>
    public void Interact()
    {
        /// <summary>Interact</summary>
        throw NotImplementedException();
    }

    public void Break()
    {
        /// <summary>Interact</summary>
        throw NotImplementedException();
    }

    public void Collect()
    {
        /// <summary>Interact</summary>
        throw NotImplementedException();
    }
}