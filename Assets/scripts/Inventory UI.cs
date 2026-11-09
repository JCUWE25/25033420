using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
   public Inventory inventory;
    public List<GameObject> UIButtons = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnEnable()
    {
         RefreshInventory();
    }

    void RefreshInventory() 
    {
        Debug.Log("refresh inventory UI");
    }
}
