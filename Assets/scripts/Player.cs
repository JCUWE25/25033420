using TMPro;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI cointxt;
    [SerializeField] GameObject coinUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PickUp pickup = other.gameObject.GetComponent<PickUp>();

        if (pickup != null)
        {
            pickup.Collect();
        }
    }
}
