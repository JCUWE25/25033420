using TMPro;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI cointxt;
   
    private int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cointxt.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        PickUp pickup = other.gameObject.GetComponent<PickUp>();

        if (pickup != null)
        {
            if (pickup.tag == "Coin") 
            {
                score++;
            }
            pickup.Collect();
        }
    }
}
