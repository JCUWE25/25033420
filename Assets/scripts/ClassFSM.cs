using Unity.VisualScripting;
using UnityEngine;

public class ClassFSM
{
    //false = gameplay / true = paused
    public bool GamePaused;

void Update() 
    {


        switch (GamePaused)
        {
            case false:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    GamePaused = true;
                }
                break;

            case true:
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    GamePaused = false;
                }
                break;

        }

    }

public class PAUSE
{
        public bool ActiveSTATE;
        private void LateUpdate() 
        {
            if (ActiveSTATE == true) 
            {
             Time.timeScale = 1.0f;
            }
       
        }
        
}

public class gameplay
{
        private void LateUpdate()
        {
            Time.timeScale = 1.0f;
        }
    }

}

