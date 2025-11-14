namespace FileLocalTypes;

internal class SomeService : IFileLocalInterface
{
    public int DoSomeWork()
    {
        FileLocalClass localInstance = new();
        return localInstance.Id.GetHashCode();
    }
}

file interface IFileLocalInterface
{
    int DoSomeWork();
}

file class FileLocalClass
{
    public Guid Id { get; } = Guid.NewGuid();
}
