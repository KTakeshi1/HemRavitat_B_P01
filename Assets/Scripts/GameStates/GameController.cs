using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game Data")]
    [SerializeField] private float TapLimitDuration;

    [Header("Dependencies")]
    /*[SerializeField]
    private Unit PlayerUnitPrefab;
    [SerializeField]
    public Transform PlayerUnitSpawnLocation;
    */
    //public UnitSpawner UnitSpawner {get; private set;}
    [SerializeField]
    public InputBroadcaster Input;

    public float _tapLimitDuration => TapLimitDuration;

    public InputBroadcaster _input => Input;
}
