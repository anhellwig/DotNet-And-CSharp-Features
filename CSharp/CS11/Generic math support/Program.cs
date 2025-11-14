int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine(Sum(numbers));

double[] floats = { 1.1, 2.2, 3.3, 4.4, 5.5 };
Console.WriteLine(Sum(floats));


// does not compile in earlier C# versions, requires static abstract members in interfaces
static T Sum<T>(IEnumerable<T> values) where T : System.Numerics.INumber<T>
{
    T result = T.Zero; // static abstract Zero property is defined in INumberBase

    foreach (T value in values)
    {
        result += value; // static abstract + operator is defined in IAdditionOperators
    }

    return result;
}
