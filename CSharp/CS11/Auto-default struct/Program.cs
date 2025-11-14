MyStruct myStruct = new();
Console.WriteLine($"X: {myStruct.X}, Y: {myStruct.Y}");
myStruct.Y = 100;
Console.WriteLine($"X: {myStruct.X}, Y: {myStruct.Y}");

// This would not compile with C# 10 or earlier
struct MyStruct
{
    public int X;
    public int Y;

    public MyStruct()
    {
        X = 42;
        // starting with C# 11, Y is initialized to its default value of 0 automatically
    }
}
