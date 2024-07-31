<Query Kind="Program" />

void Main()
{
	int Target = 3;
	var Solution = new Solution();
	var Result = Solution.GenerateMatrix(Target);
	Result.Dump();
}


public class Solution
{
	public int[][] GenerateMatrix(int n)
	{
		int[][] answer = new int[n][];
		for (int i = 0; i < n; i++)
			answer[i] = new int[n];
		int start = 0;
		int end = n - 1;
		int tmp = 1;
		while (tmp < n * n)
		{
			for (int i = start; i < end; i++) answer[start][i] = tmp++;
			for (int i = start; i < end; i++) answer[i][end] = tmp++;
			for (int i = end; i > start; i--) answer[end][i] = tmp++;
			for (int i = end; i > start; i--) answer[i][start] = tmp++;
			start++;
			end--;
		}
		if (n % 2 == 1) answer[n / 2][n / 2] = tmp;
		return answer;
	}
}
