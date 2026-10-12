using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUp : InventoryAbstract
{
    [SerializeField] GameObject CoinUI;
    [SerializeField] TextMeshProUGUI coinCounter;

    bool HasPickedUp;
    int CoinNum;
    public List<string> items = new List<string>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HasPickedUp == true) 
        {
            AddItemToInventory("coin");
        CoinNum = items.Count;
        coinCounter.text=CoinNum.ToString();
            HasPickedUp = false;
        }
        //get rid of coin
        if (Input.GetKeyDown(KeyCode.T))
        {
            RemoveItemFromInventory("coin");
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            HasPickedUp = true;
        Destroy(other);
        }
    }

    public override void AddItemToInventory(string itemName)
    {
        items.Add(itemName);
    }

    public override void RemoveItemFromInventory(string itemName)
    {
        items.Remove(itemName);
    }

}
