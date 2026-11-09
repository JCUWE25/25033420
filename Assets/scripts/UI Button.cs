using TMPro;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] TMP_Text buttonTXT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetButton(ItemClassInventory item) 
    {
        string itemName = item.name;

        buttonTXT.text = itemName;
    
    }
}
