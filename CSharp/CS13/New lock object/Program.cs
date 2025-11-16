List<int> numbers = [];

object traditionalLockObject = new();
Lock newLockObject = new();

lock (traditionalLockObject) // calls Monitor.Enter
{
    for (int i = 0; i < 10; i++)
    {
        numbers.Add(i);
    }
}

lock (newLockObject) // calls newLockObject.EnterScope and disposes at the end of the block
{
    for (int i = 0; i < 10; i++)
    {
        numbers.Add(i);
    }
}

// shorthand for:
//Lock.Scope scope = newLockObject.EnterScope();
//try
//{
//    for (int i = 0; i < 10; i++)
//    {
//        numbers.Add(i);
//    }
//}
//finally
//{
//    scope.Dispose();
//}

Console.WriteLine(string.Join(", ", numbers));
