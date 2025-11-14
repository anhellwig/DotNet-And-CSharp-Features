// traditional type or namespace alias:
using RE = System.Text.RegularExpressions;
using DPoint = System.Drawing.Point;

// now you can alias any type:
using Point = (int x, int y);
using IntArray = int[];
using NullableInt = int?;
//using NullableString = string?;   we cannot alias nullable reference types (string and string? are actually the same type)


Point p = new(3, 4);
Console.WriteLine($"{p.x}; {p.y}");

IntArray arr = [1, 2, 3];

NullableInt i = null;
