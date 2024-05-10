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
        _controller._damienHealth.text = _controller._damien.currenthitpoints.ToString();
        _controller._cyrilleHealth.text = _controller._cyrille.currenthitpoints.ToString();
        _controller._sabineHealth.text = _controller._sabine.currenthitpoints.ToString();
        _controller._geraldHealth.text = _controller._gerald.currenthitpoints.ToString();
        _controller._enemyHealth.text = _controller._goblins.currenthitpoints.ToString();
        
    }
    public override void Exit()
    {
        base.Exit();
        Debug.Log("END: End Game Setup");
    }
    public override void FixedTick()
    {
        base.FixedTick();
    }
    public override void Tick()
    {
        base.Tick();

        _stateMachine.ChangeState(_stateMachine.StartRoundState);
    }
}
