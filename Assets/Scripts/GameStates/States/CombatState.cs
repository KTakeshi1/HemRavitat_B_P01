using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatState : State
{
    private GameFSM _stateMachine;
    private GameController _controller;

    public CombatState(GameFSM stateMachine, GameController controller)
    {
        _stateMachine = stateMachine;
        _controller = controller;
    }

    public override void Enter()
    {
        base.Enter();

        Debug.Log("STATE: Combat Phase");
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
        _controller._damien.AttackEnemy(_controller._rollDice.rollVal);
        _controller._sabine.AttackEnemy(_controller._rollDice.rollVal);
        _controller._cyrille.AttackEnemy(_controller._rollDice.rollVal);
        _controller._gerald.AttackEnemy(_controller._rollDice.rollVal);
    }
}
