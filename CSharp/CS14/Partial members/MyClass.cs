using System.ComponentModel;

namespace PartialMembers;

internal partial class MyClass : MyBaseClass
{
    // We're just declaring the constructor here:
    public partial MyClass();

    // We're declaring the event here using the field-like syntax:
    public partial event EventHandler<PropertyChangedEventArgs>? PropertyChanged;

    public void DoSomething1() => Console.WriteLine("Doing something from part 1...");
}
