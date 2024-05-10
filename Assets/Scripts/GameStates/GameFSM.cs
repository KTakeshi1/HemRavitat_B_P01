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
    public RoundEndState EndRoundState {get; private set; }
    public WonState WinningState {get; private set; }
    public TransitionState TransitioningState {get; private set; }
    public DefeatState DefeatedState {get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        _controller = GetComponent<GameController>();

        SetupState = new GameSetupState(this, _controller);
        GameCombatstate = new CombatState(this, _controller);
        GameReststate = new RestState(this, _controller);
        PlayerMainstate = new MainState(this, _controller);
        StartRoundState = new RoundStartState(this, _controller);
        EndRoundState = new RoundEndState(this, _controller);
        WinningState = new WonState(this, _controller);
        TransitioningState = new TransitionState(this, _controller);
        DefeatedState = new DefeatState(this, _controller);

    }

    private void Start()
    {
        ChangeState(SetupState);
    }


}
