using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public playerBaseState currentState;
    public playerGameplaySTATE GameplaySTATE = new GameplaySTATE;
    public playerPauseSTATE pauseSTATE = new pauseSTATE;

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
    public void switchState(playerBaseState  state) 
    {
    currentState = state;
        state.EnterState(this);
    }
}
