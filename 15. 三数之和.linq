<Query Kind="Program" />

void Main()
{
	var nums = new int[] { -1, 0, 1, 2, -1, -4 };
	ThreeSum(nums).Dump();
}
public IList<IList<int>> ThreeSum(int[] nums)
{
	var result = new List<IList<int>>();
	Array.Sort(nums);

	for (int i = 0; i < nums.Length - 2; i++)
	{
		int n1 = nums[i];

		if (n1 > 0)
			break;

		if (i > 0 && n1 == nums[i - 1])
			continue;

		int left = i + 1;
		int right = nums.Length - 1;

		while (left < right)
		{
			int n2 = nums[left];
			int n3 = nums[right];
			int sum = n1 + n2 + n3;

			if (sum > 0)
			{
				right--;
			}
			else if (sum < 0)
			{
				left++;
			}
			else
			{
				result.Add(new List<int> { n1, n2, n3 });

				while (left < right && nums[right] == n3)
				{
					right--;
				}
			}

		}
	}
	return result;
}

// You can define other methods, fields, classes and namespaces here
//https://leetcode.cn/problems/3sum/
/*给你一个整数数组 nums ，判断是否存在三元组 [nums[i], nums[j], nums[k]] 满足 i != j、i != k 且 j != k ，
同时还满足 nums[i] + nums[j] + nums[k] == 0 。请你返回所有和为 0 且不重复的三元组。
注意：答案中不可以包含重复的三元组。*/