class MyStack
{
    public static void Main()
    {
        Stack<int> numbers = new Stack<int>(5);
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);
        numbers.Push(5);
        int number1 = numbers.Pop();
        Console.WriteLine(number1);
        int number2 = numbers.Pop();
        Console.WriteLine(number2);
        int number3 = numbers.Pop();
        Console.WriteLine(number3);
        int number4 = numbers.Pop();
        Console.WriteLine(number4);
        int number5 = numbers.Pop();
        Console.WriteLine(number5);
    }
}
