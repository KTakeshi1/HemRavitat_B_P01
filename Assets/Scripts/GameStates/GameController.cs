using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game Data")]
    [SerializeField] private float TapLimitDuration;
    [SerializeField] public int _turnNumber;
    [SerializeField] public int _rollModifier;

    [Header("Characters")]
    public Damien _damien;
    public Gerald _gerald;
    public Sabine _sabine;
    public Cyrille _cyrille;

    
    [Header("Script Calls")]
    public DiceRoll _rollDice;

    private int _playerTurn =  0;

    [Header("Text Mesh Pro")]
    //public TextMeshProUGUI _gameInfo;
    public TextMeshProUGUI _PlayerTurnStatus;
    public TextMeshProUGUI _NextTurnText;

    [Header("Panels")]
    public GameObject _ShopObj;
    public GameObject _WinnerPanel;

    [Header("Buttons")]
    public Button attackButton;
    
    public GameObject _NextTurnButton;
    [HideInInspector]
    public bool _TransitionToNextTurn = false;

    public GameObject _NextRoundButton;
    [HideInInspector]
    public bool _TransitionToNextRound = false;
    
    [SerializeField]
    public InputBroadcaster Input;

    public float _tapLimitDuration => TapLimitDuration;

    public InputBroadcaster _input => Input;
    
    public void NextTurnPressed()
    {
        _TransitionToNextTurn = true;
    }
    public void NextRoundPressed()
    {
        _TransitionToNextRound = true;
        
    }

}
