// Traditional collection initialization:

using System.Collections.ObjectModel;

int[] oldArray = { 1, 2, 3, 4, 5, 6, 7, 8 };

List<double> oldList = new() { 1.0, 2.0, 3.0 };


// C# 12 introduces a new terse syntax, which works for arrays, Span,
// interfaces like IEnumerable<T>, and types that supports a collection initializer:

int[] array = [1, 2, 3, 4, 5, 6, 7, 8];

List<double> list = [42.0];

ReadOnlyCollection<string> collection = ["Hello", "world"];

Span<char> span = ['H', 'e', 'l', 'l', 'o', '!'];

PrintElements(['H', 'e', 'l', 'l', 'o', '!']);

int[] a1 = [1, 2, 3];
int[] a2 = [4, 5, 6];
int[][] jaggedArray = [a1, a2];
int[] concatenatedArray = [.. a1, .. a2]; // with spread element '..'


static void PrintElements<T>(IEnumerable<T> elements) => Console.WriteLine(string.Join("; ", elements));
