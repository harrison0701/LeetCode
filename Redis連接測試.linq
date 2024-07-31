<Query Kind="Statements">
  <NuGetReference>StackExchange.Redis</NuGetReference>
  <Namespace>StackExchange.Redis</Namespace>
</Query>

string connectionString = "jbpublish.eastasia.cloudapp.azure.com:6379,password=Aa!00000000";
ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(connectionString);

IDatabase db = redis.GetDatabase();
string value = db.StringGet("testttt");
value.Dump();