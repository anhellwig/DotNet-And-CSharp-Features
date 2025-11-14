namespace GenericAttributes;

// technique to be used in previous version of C#, utilizing a constructor parameter:
[AttributeUsage(AttributeTargets.Method)]
public class MyCustomAttribute : Attribute
{
    public MyCustomAttribute(Type t) => ParamType = t;
    public Type ParamType { get; }
}

// C# 11 generic attributes feature:
[AttributeUsage(AttributeTargets.Method)]
public class MyCustomGenericAttribute<T> : Attribute { }

public class ExampleConverter
{
    [MyCustom(typeof(string))]
    [MyCustomGeneric<string>]
    public static string Method() => Guid.NewGuid().ToString();
}
