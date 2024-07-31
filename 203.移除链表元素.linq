<Query Kind="Program" />

public class Program
{
	public static void Main()
	{
		// 創建一個示例鏈表: 1 -> 2 -> 6 -> 3 -> 4 -> 5 -> 6
		//ListNode head = new ListNode(1,	new ListNode(2, new ListNode(6, new ListNode(3,	new ListNode(4,	new ListNode(5,	new ListNode(6)))))));
		ListNode head = new ListNode(1,new ListNode(2));

		int valToRemove = 6;

		Solution solution = new Solution();
		ListNode result = solution.RemoveElements(head, valToRemove);

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
	public ListNode RemoveElements(ListNode head, int val)
	{
		ListNode dummyHead = new ListNode(0, head); // 創建虛擬頭節點
		ListNode temp = dummyHead; // 初始化臨時指針指向虛擬頭節點

		while (temp.next != null) // 遍歷鏈表
		{
			if (temp.next.val == val) // 如果下一個節點的值等於目標值
			{
				temp.next = temp.next.next; // 跳過下一個節點
			}
			else
			{
				temp = temp.next; // 移動到下一個節點
			}
		}

		return dummyHead.next; // 返回處理後的鏈表頭節點
	}
}


