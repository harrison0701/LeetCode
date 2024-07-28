<Query Kind="Program">
  <Connection>
    <ID>ae98c23f-23b0-4393-880d-2d6a2688c6aa</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>FakeXiechengDb</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

void Main()
{
	var ss = new int[] { 1, 4, 3 };
	var target = 7;
	var sss = TwoSum(ss, target).Dump();
}

public int[] TwoNumberSum(int[] Number, int target)
{
	for (int i = 0; i < Number.Length; i++)
		for (int j = i + 1; j < Number.Length; j++)
		{
			if (Number[i] + Number[j] == target)
			{
				return new int[] { i, j };
			}
		}
	return null;
}
public int[] TwoSum(int[] nums, int target)
{
	Dictionary<int, int> dic = new Dictionary<int, int>();
	for (int i = 0; i < nums.Length; i++)
	{
		int imp = target - nums[i];
		if (dic.ContainsKey(imp) && dic[imp] != i)
		{
			return new int[] { i, dic[imp] };
		}
		if (!dic.ContainsKey(nums[i]))
		{
			dic.Add(nums[i], i);
		}
	}
	return new int[] { 0, 0 };
}
// You can define other methods, fields, classes and namespaces here