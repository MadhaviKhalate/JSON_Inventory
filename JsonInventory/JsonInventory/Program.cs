namespace JsonInventory;

public class Program
{
    public static void Main(string[] args)
    { 
        var log = NLog.LogManager.GetCurrentClassLogger();
        log.Warn("Enter choice in integer only.");
        Console.WriteLine("Which JSON you want to view:\n1.Inventoy Management\n2.Stock Account");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                log.Info("json for Inventory Management");
                JsonInventory.JSONMain Json = new JsonInventory.JSONMain();
                Json.ConvertMethod(@"D:\BridgeLabzFelloship\JSON_Inventory\JsonInventory\JsonInventory\JsonInventory.json");
                break;
            case 2:
                log.Info("Json for Stock Account");
                JsonInventory.StockPortfolioModel stock = new JsonInventory.StockPortfolioModel();
                stock.convert(@"D:\BridgeLabzFelloship\JSON_Inventory\JsonInventory\JsonInventory\JsonPortfolio.json");
                break;
            default:
                Console.WriteLine("Invalid choice:");
                break;
        }
    }
}