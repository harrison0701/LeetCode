<Query Kind="Program" />


public static void Main()
{


	string s1 = "abc";
	string s2 = "cba";
	bool result1 = IsAnagram(s1, s2);
	Console.WriteLine($"Is \"{s1}\" an anagram of \"{s2}\"? {result1}");

	string s3 = "hellopp";
	string s4 = "billion";
	bool result2 = IsAnagram(s3, s4);
	Console.WriteLine($"Is \"{s3}\" an anagram of \"{s4}\"? {result2}");
}


static bool IsAnagram(string s, string t)
{
   int s1= s.Length,t1 = t.Length;
   if (s1!=t1) return false;
   int[] a = new int[26];
   
   for(int i=0; i< s1;i++)
   {
		a[s[i] - 'a']++;
		a[t[i] - 'a']--;
	}
   var Result = !a.Any(x => x > 0 );
   return Result;
   
}

// You can define other methods, fields, classes and namespaces here