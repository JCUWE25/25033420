using Unity.VisualScripting;
using UnityEngine;

public class ClassFSM
{
    //false = gameplay / true = paused
    public bool GamePaused;
   
    public int StateNum;

    public Update() 
    {


        switch (StateNum)
        {
            case 0:
                
                  Gameplay.realtime();
                if (Input.GetKeyDown(KeyCode.Return))
                {

                  
                    StateNum = 1;
                    

                }
                break;

            case 1:
                
                 Pause.slow();
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    
                   
                    StateNum = 0;
                  

                }
                break;

        }

    }



}

// 1
public class Pause
{

    public static void slow() 
    {
        Time.timeScale = 1.0f;

    }
}
// 2
public class Gameplay
{
    public static void realtime()
    {
        Time.timeScale = 0.0f;

    }

}