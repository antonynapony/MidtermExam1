using MidtermExam1;

MyStack stack = new MyStack(6);
stack.Push(24);
stack.Push(-22);
stack.Push(12);
stack.Push(98);
stack.Push(7);
stack.Push(9);
var number = stack.Pop();
Console.WriteLine(number);