namespace JsonInventory;

public class Program
{
    public static void Main(string[] args)
    {
        JsonInventory.JSONMain json = new JsonInventory.JSONMain();
        json.Convert(@"D:\BridgeLabzFelloship\JSON_Inventory\JsonInventory\JsonInventory\JsonInventory.json");
    }
}