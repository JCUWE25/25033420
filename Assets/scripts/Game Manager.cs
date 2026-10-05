using UnityEngine;
  
public enum GameState { GAMEPLAY, PAUSE}
  
public class GameManager : MonoBehaviour
{
  public bool hasChangedState;
  public GameState state;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (state == GameState.GAMEPLAY)
        //{

        //    if (Input.GetKeyDown(KeyCode.Return))
        //    {
        //        state = GameState.PAUSE;
        //        hasChangedState = true;
        //    }

        //}
        //else if (state == GameState.PAUSE)
        //{

        //    if (Input.GetKeyDown(KeyCode.Return))
        //    {
        //        state = GameState.GAMEPLAY;
        //        hasChangedState = true;
        //    }

        //}

        switch (state)
        {
            case GameState.GAMEPLAY:
                if (Input.GetKeyDown(KeyCode.Return))
                        {
                            state = GameState.PAUSE;
                            hasChangedState = true;
                        }
                    break;

            case GameState.PAUSE:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    state = GameState.GAMEPLAY;
                    hasChangedState = true;
                }
                break; 
        
        }
    }


  

    private void LateUpdate()
    {

        if (hasChangedState) 
        {
            if (state == GameState.GAMEPLAY) 
            {
                Time.timeScale = 0.0f;
            }
            else if(state == GameState.PAUSE) 
            {
                Time.timeScale = 1.0f; 
            }
            hasChangedState= false;
        }

    }
}
