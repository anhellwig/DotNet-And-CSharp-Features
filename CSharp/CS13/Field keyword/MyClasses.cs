using System.ComponentModel;
using System.Runtime.Versioning;

// Previous C# versions
class PreviousCSharpClass : INotifyPropertyChanged
{
    public int myProperty;

    public int MyProperty
    {
        get => myProperty;
        set
        {
            myProperty = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}

// C# 13 with 'field' keyword
[RequiresPreviewFeatures]
class CSharp14Class : INotifyPropertyChanged
{
    public int MyProperty
    {
        get;
        set
        {
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyProperty)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
