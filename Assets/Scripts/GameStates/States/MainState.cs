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
        _controller._PlayerTurnStatus.text = _controller._turnNumber.ToString();
        Debug.Log("STATE: Game Main");
        
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
