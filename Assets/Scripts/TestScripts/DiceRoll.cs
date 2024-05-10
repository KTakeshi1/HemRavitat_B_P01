using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int rollVal;
    public bool isAttack = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RollTheDice()
    {
        rollVal = Random.Range(1, 6);
        Debug.Log(rollVal);
        isAttack = true;
    }
}
