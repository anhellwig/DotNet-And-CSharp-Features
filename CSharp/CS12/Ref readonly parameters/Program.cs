string myGreeting = "Hello world!";

MethodUsingRefReadonly(in myGreeting);
MethodUsingRefReadonly(ref myGreeting);
MethodUsingRefReadonly(myGreeting); // works, but causes compiler warning - you should use annotation
MethodUsingRefReadonly("Another hello world!"); // works, but causes compiler warning - used with rvalue/expression

MethodUsingIn(in myGreeting);
MethodUsingIn(ref myGreeting); // works, but causes compiler warning
MethodUsingIn("Another hello world!");


static void MethodUsingRefReadonly(ref readonly string text)
{
    Console.WriteLine(text);
}


static void MethodUsingIn(in string text)
{
    Console.WriteLine(text);
}
