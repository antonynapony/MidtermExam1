namespace MidtermExam1
{
    public class MyStack
    {
        private int[] _stack;
        private int _pointer;

        public MyStack(int size)
        {
            _stack = size > 0 ? new int[size] : throw new ArgumentException(nameof(size));
            _pointer = -1;
        }

        public bool Push(int value)
        {
            bool isSuccess = true;
            if (_pointer == _stack.Length - 1)
            {
                isSuccess = false;
            }
            _stack[++_pointer] = value;

            return isSuccess;
        }

        public int? Pop()
        {
            if ( _pointer == -1)
            {
                return null;
            }
            return _stack[_pointer--];
        }
    }
}
