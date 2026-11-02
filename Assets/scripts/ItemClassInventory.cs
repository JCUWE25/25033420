using System.Collections.Generic;
using UnityEngine;

public class ItemClassInventory : MonoBehaviour
{
    public string ItemName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollect() 
    {

        gameObject.SetActive(false);
    }
}
