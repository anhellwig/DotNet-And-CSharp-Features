MyRefStruct myRefStruct = new();

DoSomething(myRefStruct);


static void DoSomething<T>(T arg) where T : IMyInterface, allows ref struct
{
    Console.WriteLine($"Called with type {typeof(T)}.");
    arg.MyMethod();
}

ref struct MyRefStruct : IMyInterface
{
    public readonly void MyMethod() => Console.WriteLine("MyRefStruct MyMethod called");
}

interface IMyInterface
{
    void MyMethod();
}
