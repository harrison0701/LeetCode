<Query Kind="Statements">
  <Namespace>System.Text.Json</Namespace>
</Query>


string jsonString = "{\"PlatformID\":0,\"MerchantID\":2000132,\"RpHeader\":{\"Timestamp\":1709621019,\"RqID\":\"e50f5725-f5e0-477e-9e7d-373d77c2c3fe\",\"Revision\":null},\"TransCode\":1,\"TransMsg\":\"Success\",\"Data\":\"XiPrW0fY9qcvZyZ3p4YO9Lmy/26tRJYNg7kUScZ2pi0tTmU9lPaYomsTDWIi8QHGeHn0evGvd2e1nu+6s4r7BtU7wrH0bJXfQIbXbx185mjc6lF9lxwIoSK1G/NnP5VdaGBE0FM1Cbu11AQPbGQE+A==\"}";

// 使用 System.Text.Json 解析 JSON 字符串
JsonDocument jsonDoc = JsonDocument.Parse(jsonString);

// 获取顶层对象
JsonElement root = jsonDoc.RootElement;
// 获取 "Data" 属性的值
string dataValue = root.GetProperty("Data").GetString();
// 关闭 JsonDocument
jsonDoc.Dispose();

dataValue.Dump();