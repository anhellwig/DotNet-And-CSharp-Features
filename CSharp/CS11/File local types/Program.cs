using FileLocalTypes;

SomeService service = new();
Console.WriteLine($"Work result: {service.DoSomeWork()}");

// cannot access file-local interface from here
//if (service is IFileLocalInterface)
//{
//    Console.WriteLine("service implements IMyInterface");
//}
