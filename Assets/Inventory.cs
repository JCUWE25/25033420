using UnityEngine;
using System.Collections.Generic;
public class Inventory : MonoBehaviour
{
    [SerializeField] GameManager inventoryManagement;
    [SerializeField] string NewName;
    [SerializeField] Transform worldItems;
    public List<ItemClassInventory> items = new List<ItemClassInventory>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventoryManagement = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //if (inventoryManagement.state == GameState.GAMEPLAY) 
        //{
        //if (Input.GetKeyDown(KeyCode.R)) 
        //{
        //    AddItemToInventory(NewName);
        //}
        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    RemoveItemFromInventory(NewName);
        //}
        //}
    }
    //public override void AddItemToInventory(string itemName)
    //{
    //items.Add(itemName);
    //}

    //public override void RemoveItemFromInventory(string itemName)
    //{
    //    items.Remove(itemName);
    //}
    public  void AddItemToInventory(ItemClassInventory item)
    {
        items.Add(item);
        item.OnCollect();
    }

    public  void RemoveItemFromInventory()
    {
        if (items.Count > 0) 
        {
        ItemClassInventory item = items[0];
            GameObject itemObject = item.gameObject;

            items.Remove(item);

            Vector3 position = GetComponent<Transform>().position + GetComponent<Transform>().forward + Vector3.up;

            Quaternion rotation = Quaternion.Euler(0, 180, 0) * GetComponent<Transform>().rotation;

            GameObject newItem = Instantiate(itemObject, position, rotation, worldItems);
            newItem.SetActive(true);

            Destroy(itemObject);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ItemClassInventory item = hit.gameObject.GetComponent<ItemClassInventory>();

        if (item != null) 
        {
            //items.Add(item.ItemName);
            //item.OnCollect();
            AddItemToInventory(item);
        }
    }
}
