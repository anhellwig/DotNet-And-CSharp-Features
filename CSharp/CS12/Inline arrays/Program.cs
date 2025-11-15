internal class Program
{
    const int bufferLength = 10;

    private static int Main()
    {        
        IntBuffer buffer = new();

        for (int i = 0; i < bufferLength; i++)
        {
            buffer[i] = i;
        }

        foreach (int i in buffer)
        {
            Console.WriteLine(i);
        }

        return 0;
    }

    [System.Runtime.CompilerServices.InlineArray(bufferLength)]
    internal struct IntBuffer
    {
        // The struct must contain a single field.
        // The type can be any value type or reference type, but not a pointer.
        private int numbers;

        // equivalent to fixed-size buffer, but that world require unsafe context:
        //public fixed int fixedBuffer[bufferLength]; 
    }
}
