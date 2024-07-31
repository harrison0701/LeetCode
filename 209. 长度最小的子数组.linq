<Query Kind="Program" />

void Main()
{
	int Target = 7;
	int[] nums = new int[] { 2, 3, 1, 2, 4, 3 };
	var Solution = new Solution();
	var Result = Solution.MinSubArrayLen(Target, nums);
	Result.Dump();
}

public class Solution
{
	public int MinSubArrayLen(int Target, int[] nums)
	{
		int n = nums.Length;             // 獲取數組的長度
		int ans = int.MaxValue;          // 初始化結果為最大值
		int start = 0, end = 0;          // 初始化滑動窗口的起始和結束指針
		int sum = 0;                     // 初始化窗口內元素的和

		while (end < n)                  // 遍歷數組
		{
			sum += nums[end];            // 將當前元素加入窗口和
			while (sum >= Target)             // 當窗口內的和大於或等於目標值 s 時
			{
				ans = Math.Min(ans, end - start + 1); // 更新最小子數組長度
				sum -= nums[start];      // 移動窗口左邊界，從和中減去 start 元素
				start++;                 // 將左邊界向右移動
			}
			end++;                       // 將右邊界向右移動
		}

		return ans == int.MaxValue ? 0 : ans; // 如果沒有找到符合條件的子數組，返回 0，否則返回最小長度
	}
}
