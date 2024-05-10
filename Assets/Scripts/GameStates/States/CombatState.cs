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
        if(_controller._damien.currenthitpoints <= 0 && _controller._sabine.currenthitpoints <= 0 && _controller._cyrille.currenthitpoints <= 0 && _controller._gerald.currenthitpoints <= 0)
        {
            _stateMachine.ChangeState(_stateMachine.DefeatedState);    
        }
        else if(_controller._goblins.currenthitpoints <= 0)
        {
            _stateMachine.ChangeState(_stateMachine.WinningState);   
        }
        _stateMachine.ChangeState(_stateMachine.TransitioningState);
    }

    public override void Tick()
    {
        _controller.DiceRollEnenmy();
        _controller._damien.AttackEnemy(_controller._rollDice.rollVal);
        _controller._sabine.AttackEnemy(_controller._rollDice.rollVal);
        _controller._cyrille.AttackEnemy(_controller._rollDice.rollVal);
        _controller._gerald.AttackEnemy(_controller._rollDice.rollVal);
        
        _controller._damageAmt =_controller._damien.dmgpoints + _controller._sabine.dmgpoints + _controller._cyrille.dmgpoints + _controller._gerald.dmgpoints;
        _controller._goblins.currenthitpoints = _controller._goblins.currenthitpoints - _controller._damageAmt;

        _controller._goblins.AttackPlayer(_controller._rollModifierEnemy);
        _controller._damien.currenthitpoints = _controller._damien.currenthitpoints - _controller._goblins.dmgpoints;
        _controller._sabine.currenthitpoints = _controller._sabine.currenthitpoints - _controller._goblins.dmgpoints;
        _controller._cyrille.currenthitpoints = _controller._cyrille.currenthitpoints - _controller._goblins.dmgpoints;
        _controller._gerald.currenthitpoints = _controller._gerald.currenthitpoints - _controller._goblins.dmgpoints;
    }
}
