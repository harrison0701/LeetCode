<Query Kind="Program" />

class Program
{
    static void Main(string[] args)
    {
        var data = new List<MyObject>
        {
            new MyObject { Values = new List<string> { "Hello", "", "World", "unwanted" } },
            new MyObject { Values = new List<string> { "Foo", "Bar", "", "unwanted" } }
        };

        string result = JoinLists(data, x => x.Values, ", ");
        var ss = result.Dump(); // Output: "HelloWorld, FooBar"
    }

    public static string JoinLists<T, TKey>(IEnumerable<T> list, Func<T, IEnumerable<TKey>> selector, string separator)
    {
        // 固定的过滤条件：排除空字符串和特定字符串 "unwanted"
        Func<TKey, bool> filter = key => 
        {
            var str = key?.ToString();
            return !string.IsNullOrEmpty(str) && str != "unwanted";
        };

        return string.Join(separator, list.Select(item => 
            string.Join("", selector(item).Where(filter))
        ));
    }
}

class MyObject
{
    public IEnumerable<string> Values { get; set; }
}
