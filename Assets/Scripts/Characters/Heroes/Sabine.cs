using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sabine : MonoBehaviour
{
    public int hitpoints = 15;
    public int currenthitpoints = 15;
    public int dmgpoints = 6;

    public void AttackEnemy(int valmodifier)
    {
        dmgpoints = valmodifier * dmgpoints;
    }
}
