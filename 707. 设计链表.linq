<Query Kind="Program">
  <RuntimeVersion>7.0</RuntimeVersion>
</Query>

public class Program
{
	public static void Main()
	{
		MyLinkedList list = new MyLinkedList();
		list.AddAtHead(1);
		list.AddAtTail(3);
		list.AddAtIndex(1, 2);   //鏈表變為1->2->3
		Console.WriteLine(list.Get(1)); //返回2
		list.DeleteAtIndex(1);  //現在鏈表是1->3
		Console.WriteLine(list.Get(1)); //返回3
	}
}

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val) { this.val = val; }
}
public class MyLinkedList
{
    ListNode dummyHead;
    int count;

    public MyLinkedList()
    {
        dummyHead = new ListNode(0);
        count = 0;
    }

    public int Get(int index)
    {
        if (index < 0 || count <= index) return -1;
        ListNode current = dummyHead;
        for (int i = 0; i <= index; i++)
        {
            current = current.next;
        }
        return current.val;
    }

    public void AddAtHead(int val)
    {
        AddAtIndex(0, val);
    }

    public void AddAtTail(int val)
    {
        AddAtIndex(count, val);
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > count) return;
        index = Math.Max(0, index);
        count++;
        ListNode tmp1 = dummyHead;
        for (int i = 0; i < index; i++)
        {
            tmp1 = tmp1.next;
        }
        ListNode tmp2 = new ListNode(val);
        tmp2.next = tmp1.next;
        tmp1.next = tmp2;
    }

    public void DeleteAtIndex(int index)
    {

        if (index >= count || index < 0) return;
		var tmp1 = dummyHead;
		for (int i = 0; i < index; i++)
		{
			tmp1 = tmp1.next;
		}
		tmp1.next = tmp1.next.next;
		count--;

	}
}

//https://leetcode.cn/problems/design-linked-list/description/
//刪除節點的操作為 指到下下個節點

