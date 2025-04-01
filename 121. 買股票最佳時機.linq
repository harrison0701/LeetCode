<Query Kind="Program" />

void Main()
{
	var prices = new int[] { 7, 1, 5, 3, 6, 4}; 
	MaxProfit(prices).Dump();
}
public int MaxProfit(int[] prices)
{
	if (prices.Length == 0) return 0;

	int minPrice = prices[0];
	int maxProfit = 0;

	for (int i = 1; i < prices.Length; i++)
	{
		if (prices[i] < minPrice)
		{
			minPrice = prices[i]; // 更新最低買入價
		}
		else
		{
			int currentProfit = prices[i] - minPrice;
			if (currentProfit > maxProfit)
			{
				maxProfit = currentProfit; // 更新最大利润
			}
		}
	}

	return maxProfit;
}
// You can define other methods, fields, classes and namespaces here