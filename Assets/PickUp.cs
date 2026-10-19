using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUp : MonoBehaviour
{
 

     private bool HasPickedUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HasPickedUp == true) 
        {
  
        }
        
    }

    public virtual void Collect()
    {
        gameObject.SetActive(false);
    }
}
