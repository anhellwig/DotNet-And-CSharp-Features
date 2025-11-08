using PartialMembers;

MyClass myClass = new();

Console.WriteLine($"MyClass Id: {myClass.Id}");

myClass.DoSomething1();
myClass.DoSomething2();

myClass.PropertyChanged += (s, e) =>
{
    Console.WriteLine($"Property '{e.PropertyName}' has changed.");
};

myClass.SomeProperty = 42;
