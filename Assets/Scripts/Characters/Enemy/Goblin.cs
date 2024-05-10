using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public int hitpoints = 45;
    public int currenthitpoints = 45;
    public int dmgpoints = 4;

    public void AttackPlayer(int valmodifier)
    {
        dmgpoints = valmodifier * dmgpoints;
    }
}
