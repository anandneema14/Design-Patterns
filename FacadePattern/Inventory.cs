using FacadePattern.Interfaces;

namespace FacadePattern;

public class Inventory : IInventory
{
    public bool CheckInventory()
    {
        return true;
    }

    public void UpdateInventory()
    {
        Console.WriteLine("Inventory updated");
    }
}