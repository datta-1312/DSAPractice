public class MyQueue {
    Stack<int> stack1;
    Stack<int> stack2;
    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    public void Push(int x)
    {
        Reset();
        stack1.Push(x);
    }

    public int Pop()
    {
        Set();
        if (stack2.Count == 0) return 0;
        int result = stack2.Pop();
        Reset();
        return result;
    }

    public int Peek() {
        Set();
        if(stack2.Count == 0) return 0;
        int result = stack2.Peek();
        Reset();
        return result;
    }
    
    public bool Empty() {
        return (stack1.Count > 0) && (stack2.Count>0);
    }

    private void Reset()
    {
        while (stack2.Count > 0)
        {
            stack1.Push(stack2.Pop());
        }
    }
    private void Set()
    {
        while (stack1.Count > 0)
        {
            stack2.Push(stack1.Pop());
        }
    }
}