using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] AudioClip landing;
    [SerializeField] AudioClip footsteps;
    [SerializeField] GameObject cameraRoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnPause(InputValue value) 
    {
        if (value.isPressed) 
        {
            Debug.Log("Pause Input Pressed");

            FindAnyObjectByType<GameManager>().OnPause();
        }
    }

    void OnRemoveItem(InputValue value) 
    {
        if (value.isPressed) 
        {
            Debug.Log("Removing Item");

            if (FindAnyObjectByType<GameManager>().state == GameState.GAMEPLAY) 
            {
                FindAnyObjectByType<Inventory>().RemoveItemFromInventory();
            }
        }

    }
}
