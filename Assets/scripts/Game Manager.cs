using UnityEngine;
  
public enum GameState { GAMEPLAY, PAUSE}

public class GameManager : MonoBehaviour
{
    public bool hasChangedState;
    public GameState state;
    [SerializeField] GameObject InventUIRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    //void Update()
    //{



    //    switch (state)
    //    {
    //        case GameState.GAMEPLAY:
    //            if (Input.GetKeyDown(KeyCode.Return))
    //            {
    //                state = GameState.PAUSE;
    //                hasChangedState = true;
    //            }
    //            break;

    //        case GameState.PAUSE:
    //            if (Input.GetKeyDown(KeyCode.Return))
    //            {
    //                state = GameState.GAMEPLAY;
    //                hasChangedState = true;
    //            }
    //            break;

    //    }
    //}




    private void LateUpdate()
    {

        if (hasChangedState)
        {


            switch (state)
            {
                case GameState.GAMEPLAY:
                    Time.timeScale = 0.0f;
                    InventUIRef.SetActive(false);
                    Cursor.lockState = CursorLockMode.Locked;
                    break;
                case GameState.PAUSE:
                    InventUIRef.SetActive(true);
                    Time.timeScale = 1.0f;
                    Cursor.lockState = CursorLockMode.None;
                    break;
            }
            hasChangedState = false;
        }

    }

    public void OnPause()
       {
        switch (state)
        {
            case GameState.GAMEPLAY:
                
                    state = GameState.PAUSE;
                    hasChangedState = true;
                
                break;

            case GameState.PAUSE:
              
                    state = GameState.GAMEPLAY;
                    hasChangedState = true;
                
                break;

        }
    }
           
}


