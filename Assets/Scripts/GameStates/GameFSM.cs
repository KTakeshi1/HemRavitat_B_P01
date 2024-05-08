using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameController))]
public class GameFSM : StateMachineMB
{
    private GameController _controller;
    
    public GameSetupState SetupState {get; private set; }
    public CombatState GameCombatstate {get; private set; }
    public RestState GameReststate {get; private set; }
    public MainState PlayerMainstate {get; private set; }
    public RoundStartState StartRoundState {get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        _controller = GetComponent<GameController>();

        SetupState = new GameSetupState(this, _controller);
        GameCombatstate = new CombatState(this, _controller);
        GameReststate = new RestState(this, _controller);

    }

    private void Start()
    {
        ChangeState(SetupState);
    }


}
