namespace JsonInventory;

public class Program
{
    public static void Main(string[] args)
    {
        JsonInventory.JSONMain json = new JsonInventory.JSONMain();
        var log = NLog.LogManager.GetCurrentClassLogger();
        log.Info("Inventory Management has started");
        json.ConvertMethod(@"D:\BridgeLabzFelloship\JSON_Inventory\JsonInventory\JsonInventory\JsonInventory.json");
    }
}