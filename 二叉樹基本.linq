<Query Kind="Program" />

class Program
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;

		// 建構子，初始化節點的值和子節點
		public TreeNode(int x)
		{
			val = x;
			left = null;
			right = null;
		}
	}

	static void Main(string[] args)
	{
		// 建立二叉樹節點
		TreeNode root = new TreeNode(1);
		root.left = new TreeNode(2);
		root.right = new TreeNode(3);

		// 左子節點的子節點
		root.left.left = new TreeNode(4);
		root.left.right = new TreeNode(5);

		// 右子節點的子節點
		root.right.left = new TreeNode(6);
		root.right.right = new TreeNode(7);

		// 顯示二叉樹的結構
		PrintTree(root);
	}

	// 遞迴列印二叉樹
	static void PrintTree(TreeNode node)
	{
		if (node == null)
		{
			return ;
		}

		Console.WriteLine(node.val);
		PrintTree(node.left);
		PrintTree(node.right);
	}
}
