using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
   public Inventory inventory;
    public List<GameObject> Buttons;
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

    public void RemoveItem(int i) 
    {
        inventory.RemoveItemFromInventory(i);
        RefreshInventory();
    }
    void RefreshInventory() 
    {

        foreach  (GameObject i in Buttons)
        {
            // gameObject.SetActive(false);
           
        }

        for (int i = 0; i < inventory.items.Count; i++ ) 
        {
            if (i < Buttons.Count) 
            { 
            //GameObject UiButton = Buttons[i].GetComponent<UIButton>();
            //    GameObject item = UiButton;
            //    item.gameObject.GetComponent<UIButton>();
            //    item.SetButton();
            UIButton temp = Buttons[i].GetComponent<UIButton>();
            ItemClassInventory tempItem = inventory.items[i];
            temp.SetButton(tempItem);
            Buttons[i].SetActive(true);
            }
        }
        Debug.Log("refresh inventory UI");
    }
}
