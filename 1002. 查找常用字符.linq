<Query Kind="Program" />


public static void Main()
{

	string[] words = new string[] { "bella", "label", "roller" };
	var result1 = CommonChars(words);
	result1.Dump();

	static IList<string> CommonChars(string[] words)
	{
		int[] CountIntersection = new int[26];
		Array.Fill(CountIntersection, int.MaxValue);

		foreach (var word in words)
		{
			int[] counts = new int[26];
			foreach (char c in word)
			{
				counts[c - 'a']++;
			}

			for (int i = 0; i < 26; i++)
			{
				CountIntersection[i] = Math.Min(CountIntersection[i], counts[i]);
			}



		}
		IList<string> letters = new List<string>();
		for (int i = 0; i < 26; i++)
		{
			string letter = ((char)('a' + i)).ToString();
			int count = CountIntersection[i];
			for (int j = 0; j < count; j++)
			{
				letters.Add(letter);
			}
		}
		return letters;
	}

	//先遍歷三個字串的共通值 在印出重複的字母
}



