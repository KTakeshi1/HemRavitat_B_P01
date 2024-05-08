using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundStartState : State
{
    // Start is called before the first frame update

    private GameFSM _stateMachine;
    private GameController _controller;

    public RoundStartState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
        
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("STATE: Round Start");
        _controller._PlayerTurnStatus.text = _controller._turnNumber.ToString();
        //_controller._roundStart.Play();
        
        
    }

    public override void Exit()
    {
        base.Exit();

        Debug.Log("END: Round Start");
    }

    public override void FixedTick()
    {
        base.FixedTick();
    }

    public override void Tick()
    {
        
        _stateMachine.ChangeState(_stateMachine.PlayerMainstate);
        base.Tick();
    }
}
