<Query Kind="Program" />

void Main()
{
	MyQueue queue = new MyQueue();

	// 将元素推入队列
	queue.Push(1);
	queue.Push(2);
	queue.Push(3);

	// 获取队列头部元素
	Console.WriteLine("Peek: " + queue.Peek()); // 输出: 1

	// 弹出队列头部元素
	Console.WriteLine("Pop: " + queue.Pop()); // 输出: 1

	// 再次获取队列头部元素
	Console.WriteLine("Peek: " + queue.Peek()); // 输出: 2

	// 判断队列是否为空
	Console.WriteLine("Is Empty: " + queue.Empty()); // 输出: False

	// 再次弹出元素
	Console.WriteLine("Pop: " + queue.Pop()); // 输出: 2
	Console.WriteLine("Pop: " + queue.Pop()); // 输出: 3

	// 判断队列是否为空
	Console.WriteLine("Is Empty: " + queue.Empty()); // 输出: True
}

public class MyQueue
{
	Stack<int> inStack;
	Stack<int> outStack;

	public MyQueue()
	{
		inStack = new Stack<int>();// 负责进栈
		outStack = new Stack<int>();// 负责出栈
	}

	public void Push(int x)
	{
		inStack.Push(x);
	}

	public int Pop()
	{
		dumpstackIn();
		return outStack.Pop();
	}

	public int Peek()
	{
		dumpstackIn();
		return outStack.Peek();
	}

	public bool Empty()
	{
		return inStack.Count == 0 && outStack.Count == 0;
	}

	// 处理方法：
	// 如果outStack为空，那么将inStack中的元素全部放到outStack中
	private void dumpstackIn()
	{
		if (outStack.Count != 0) return;
		while (inStack.Count != 0)
		{
			outStack.Push(inStack.Pop());
		}
	}
}
/*
请你仅使用两个栈实现先入先出队列。队列应当支持一般队列支持的所有操作（push、pop、peek、empty）：

实现 MyQueue 类：

void push(int x) 将元素 x 推到队列的末尾
int pop() 从队列的开头移除并返回元素
int peek() 返回队列开头的元素
boolean empty() 如果队列为空，返回 true ；否则，返回 false
*/
//https://leetcode.cn/problems/implement-queue-using-stacks/description/