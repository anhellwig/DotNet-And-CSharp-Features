IService? service = FindService();

// before C# 14
if (service != null)
{
    service.SomethingHappened += (s, e) => { /*...*/ };
    service.SomeProperty = 42;
    service.DoSomething();
}

// possible with C# 14
service?.SomethingHappened += (s, e) => { /*...*/ };
service?.SomeProperty = 42;
service?.DoSomething();

// not allowed: increment/decrement operators
//service?.SomeProperty++;


return 0;

static IService? FindService()
{
    // nope, not found
    return null;
}

interface IService
{
    void DoSomething();

    int SomeProperty { get; set; }

    event EventHandler? SomethingHappened;
}
