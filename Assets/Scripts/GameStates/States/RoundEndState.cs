using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundEndState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    // Start is called before the first frame update
    public RoundEndState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        _controller.attackButton.enabled = true;
        Debug.Log("STATE: Round End");
        
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("END: Round End");
    }

    public override void FixedTick()
    {
        base.FixedTick();
        if(_controller.attackButton)
        {
            _stateMachine.ChangeState(_stateMachine.GameCombatstate);
        }
    }

    public override void Tick()
    {
        base.Tick();

        
    }
}
