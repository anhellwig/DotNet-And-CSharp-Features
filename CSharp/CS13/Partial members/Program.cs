using PartialMembers;

MyClass myClass = new();
myClass.PropertyChanged += (sender, e) =>
{
    Console.WriteLine($"{e.PropertyName} has changed.");
};

myClass.SomeProperty = "Hello, partial properties!";

Console.WriteLine($"Initial value at index 5: {myClass[5]}");
myClass[5] = 42;
Console.WriteLine($"Updated value at index 5: {myClass[5]}");
