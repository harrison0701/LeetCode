<Query Kind="Program" />

void Main()
{
	var nums = new int[] { 1, 0, -1, 0, -2, 2 };
	FourSum(nums,0).Dump();
}

public IList<List<int>> FourSum(int[] nums, int target)
{
	var result = new List<List<int>>();

	Array.Sort(nums);

	for (int i = 0; i < nums.Length - 3; i++)
	{
		int n1 = nums[i];
		if (i > 0 && n1 == nums[i - 1])
			continue;

		for (int j = i + 1; j < nums.Length - 2; j++)
		{
			int n2 = nums[j];
			if (j > i + 1 && n2 == nums[j - 1])
				continue;

			int left = j + 1;
			int right = nums.Length - 1;

			while (left < right)
			{
				int n3 = nums[left];
				int n4 = nums[right];
				int sum = n1 + n2 + n3 + n4;
				
				if(sum > target)
				{
					right--;
				}
				else if (sum < target)
				{
					left++;
				}
				else
				{
					result.Add(new List<int> {n1,n2,n3,n4});
					
					while (left < right && nums[left] == n3)
					{
						left ++;
					}
					while(left < right && nums[left] == n4)
					{
						right--;
					}
				}
			}

		}
	}


	return result;
}


// You can define other methods, fields, classes and namespaces here
//https://leetcode.cn/problems/4sum/description/
/*
给你一个由 n 个整数组成的数组 nums ，和一个目标值 target 。
请你找出并返回满足下述全部条件且不重复的四元组 [nums[a], nums[b], nums[c], nums[d]] （若两个四元组元素一一对应，则认为两个四元组重复）：

0 <= a, b, c, d < n
a、b、c 和 d 互不相同
nums[a] + nums[b] + nums[c] + nums[d] == target
你可以按 任意顺序 返回答案 。
*/