using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    // Start is called before the first frame update
    public DefeatState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        _controller._loseState.SetActive(true);
        _controller.attackButton.enabled = false;
        Debug.Log("STATE: You Won!");
        
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("END: You Won!");
    }

    public override void FixedTick()
    {
        base.FixedTick();
        
    }

    public override void Tick()
    {
        base.Tick();

        
    }
}
