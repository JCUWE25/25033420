using UnityEngine;
using System.Collections.Generic;
public class Inventory : MonoBehaviour
{
    [SerializeField] GameManager inventoryManagement;
    public List<string> items = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventoryManagement = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (inventoryManagement.state == GameState.GAMEPLAY) 
        {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            AddItemToInventory("Item A");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            RemoveItemFromInventory("Item A");
        }
        }
    }
    public void AddItemToInventory(string itemName) 
    {
    items.Add(itemName);
    }

    public void RemoveItemFromInventory(string itemName)
    {
        items.Remove(itemName);
    }
}
