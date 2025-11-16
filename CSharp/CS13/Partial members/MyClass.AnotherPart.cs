using System.ComponentModel;

namespace PartialMembers;

internal partial class MyClass : INotifyPropertyChanged
{
    private int[] numbers = [.. Enumerable.Range(1, 100).Select(i => Random.Shared.Next() / i)];
    private string? someProperty;

    // implementation declarations:
    public partial string? SomeProperty
    {
        get => someProperty;
        set
        {
            someProperty = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SomeProperty)));
        }
    }

    public partial int this[int index] 
    { 
        get => numbers[index];
        set => numbers[index] = value;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
