using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyrille : MonoBehaviour
{
    public int hitpoints = 25;
    public int currenthitpoints = 25;
    public int dmgpoints = 4;

    public void AttackEnemy(int valmodifier)
    {
        dmgpoints = valmodifier * dmgpoints;
    }

}
