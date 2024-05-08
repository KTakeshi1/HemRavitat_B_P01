using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public RestState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("STATE: Game Play");
        Debug.Log("Listen for Player Inputs");
        Debug.Log("Display Player Hud");
    }

    public override void Exit()
    {
        base.Exit();
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
