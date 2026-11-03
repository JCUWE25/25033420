using TMPro;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    string ItemInfo;
    int OrbTypeNum;
    [SerializeField] TextMeshProUGUI ItemDescrptTXT;
    [SerializeField] GameObject Owner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Owner.name == "Gold Orb") 
        {
        OrbTypeNum = 1;
        }
        else if (Owner.name == "Blue Orb") 
        {
            OrbTypeNum = 2;
        }
        else if (Owner.name == "Generic Orb")
        {
            OrbTypeNum = 3;
        }

        itemDetails();
        ItemDescrptTXT.text = ItemInfo;
       // Debug.Log(ItemInfo);
    }

    void itemDetails() 
    {
        switch (OrbTypeNum) 
        {
            case 1:
OrbClass goldenOrb = new OrbClass();
        goldenOrb.rarity = "Exotic";
        goldenOrb.roundness = 99;
        goldenOrb.Description = "Not exactly from a golden goose";

        ItemInfo = goldenOrb.rarity + goldenOrb.Description;
            break;
            case 2:
                OrbClass BlueOrb = new OrbClass();
                BlueOrb.rarity = "Uncommon";
                BlueOrb.roundness = 99;
                BlueOrb.Description = "Maybe the goose is Blue";

                ItemInfo = BlueOrb.rarity + BlueOrb.Description;
                break;
            case 3:
                OrbClass GenericOrb = new OrbClass();
                GenericOrb.rarity = "common";
                GenericOrb.roundness = 99;
                GenericOrb.Description = "maybeGoose";

                ItemInfo = GenericOrb.rarity + GenericOrb.Description;
                break;
        }
    
    }
 

}
