using UnityEngine;

public class PauseManager : MonoBehaviour
{
    baseSTATE currentState;
    public  GameplaySTATE playState = new GameplaySTATE();
    public  pauseSTATE frozenState = new pauseSTATE();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentState = GameplaySTATE;

        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }
    public void switchState(baseSTATE state) 
    {
    currentState = state;
        state.EnterState(this);
    }
}
