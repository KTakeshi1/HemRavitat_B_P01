using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSetupState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;
    // Start is called before the first frame update
    
    public GameSetupState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("STATE: Game Setup");
        Debug.Log("Load Save Data");
        Debug.Log("Spawn Units");
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

        _stateMachine.ChangeState(_stateMachine.GameCombatstate);
    }
}
