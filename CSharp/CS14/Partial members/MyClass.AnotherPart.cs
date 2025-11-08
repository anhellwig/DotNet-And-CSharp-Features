using System.ComponentModel;

namespace PartialMembers;

// Another, possibly source-generated, part of the partial class
internal partial class MyClass
{
    // Implementing the constructor here:
    public partial MyClass()
        // constructor initializer must be added on the implementing declaration
        : base(Random.Shared.Next(1, 100))
    {
        Console.WriteLine("Hello from partial constructor.");
    }

    public void DoSomething2() => Console.WriteLine("Doing something from part 2...");

    public int SomeProperty
    {
        get;
        set
        {
            field = value;
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SomeProperty)));
        }
    }

    // The implementing declaration must declare the add and remove accessors:
    private EventHandler<PropertyChangedEventArgs>? propertyChanged;
    public partial event EventHandler<PropertyChangedEventArgs>? PropertyChanged
    {
        add
        {
            propertyChanged += value;
            Console.WriteLine("Someone subscribed to PropertyChanged event.");
        }
        remove
        {
            propertyChanged -= value;
            Console.WriteLine("Someone unsubscribed from PropertyChanged event.");
        }
    }
}
