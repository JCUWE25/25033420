using UnityEngine;

 public abstract class InventoryAbstract: MonoBehaviour
{

    public abstract void AddItemToInventory(string itemName);

    public abstract void RemoveItemFromInventory(string itemName);
    
    
}
