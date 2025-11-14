// The value of the most significant bit is propagated to the high-order empty bit positions
int signedShiftedValue = -8 >> 2;

Console.WriteLine($"Signed right shift with '>>': {signedShiftedValue:X8}");

// The high-order empty bit positions are filled with zeros
int unsignedShiftedValue = -8 >>> 2;

Console.WriteLine($"Unsigned right shift with '>>>': {unsignedShiftedValue:X8}");
