<Query Kind="Program" />

public class Program
{
	public static void Main()
	{
		// 創建一個示例鏈表: 1 -> 2 -> 6 -> 3 -> 4 -> 5 -> 6
		//ListNode head = new ListNode(1,	new ListNode(2, new ListNode(3,new ListNode(4,	new ListNode(5,	new ListNode(6))))));
		ListNode head = new ListNode(1, new ListNode(2, new ListNode(3)));
		//ListNode head = new ListNode(1,new ListNode(2));

		Solution solution = new Solution();
		ListNode result = solution.ReverseList3(head);

		// 打印處理後的鏈表
		PrintList(result);
	}

	public static void PrintList(ListNode node)
	{
		while (node != null)
		{
			Console.Write(node.val + " ");
			node = node.next;
		}
		Console.WriteLine();
	}
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}

public class Solution
{
	//尾遞歸解法 3
	public ListNode ReverseList3(ListNode head)
	{
		return ReverseListTail(null, head);
	}

	public ListNode ReverseListTail(ListNode prev, ListNode curr)
	{
		if (curr == null)
		{
			return prev;
		}
		ListNode next = curr.next;
		curr.next = prev;
		return ReverseListTail(curr, next);
	}


	public ListNode reverseList(ListNode head)
	{
		ListNode prev = null, curr = head;
		while (curr != null)
		{
			ListNode next = curr.next;
			curr.next = prev;
			prev = curr;
			curr = next;
		}
		return prev;
	}

}
