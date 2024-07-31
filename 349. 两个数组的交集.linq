<Query Kind="Program" />

void Main()
{
	int[] nums1 = new int[] {1,2,2,1};
	int[] nums2 = new int[] {12,13};
	
	Intersection2(nums1,nums2).Dump();
	

}
public int[] Intersection(int[] nums1, int[] nums2)
{
	if (nums1 == null || nums1.Length == 0 || nums2 == null || nums1.Length == 0)
		return new int[0]; //注意数组条件
		
	HashSet<int> one = Insert(nums1);
	HashSet<int> two = Insert(nums2);
	one.IntersectWith(two);
	return one.ToArray();
}
public HashSet<int> Insert(int[] nums)
{
	HashSet<int> one = new HashSet<int>();
	foreach (int num in nums)
	{
		one.Add(num);
	}
	return one;
}

//另個解法
static int[] Intersection2(int[] nums1, int[] nums2)
{
	return nums1.Intersect(nums2).ToArray();
}
// You can define other methods, fields, classes and namespaces here