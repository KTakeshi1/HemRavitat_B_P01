using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting.Antlr3.Runtime.Tree;

public class MainState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    // Start is called before the first frame update
    public MainState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();
        _controller.attackButton.enabled = true;
        _controller._rollDice.isAttack = false;
        Debug.Log("STATE: Game Main");
        
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FixedTick()
    {
        base.FixedTick();
        if(_controller._rollDice.isAttack == true)
        {
            _stateMachine.ChangeState(_stateMachine.GameCombatstate);
            _controller._rollDice.isAttack = false;
        }
    }

    public override void Tick()
    {
        base.Tick();

        
    }
}
