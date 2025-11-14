# Unsigned right shift operator (>>>)

The unsigned right shift operator (`>>>`) shifts the bits of its left-hand operand to the right by the number of positions specified by its right-hand operand.
Bits shifted off to the right are discarded, and zero bits are shifted in from the left, regardless of the sign of the original number.

This feature complements the [generic math](../Generic%20math%20support) capabilities introduced in C# 11.

## Example

```csharp
int signedShiftedValue = -8 >> 2; // result: 0xFFFFFFFE
int unsignedShiftedValue = -8 >>> 2; // result: 0x3FFFFFFE
```

## Further information

* [Arithmetic operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators)
