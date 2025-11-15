using ExperimentalAttribute;

#pragma warning disable EA1234
#pragma warning disable EA1235

// A compiler error with the defined diadnostic ID will be issued if you try to instantiate the class
// or to call the experimental method, unless you disable it with #pragma.

MyClass myClass = new();
Console.WriteLine(myClass.CalculateTheNumber());
