using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerald : MonoBehaviour
{
    public int hitpoints = 10;
    public int currenthitpoints = 10;
    public int dmgpoints = 8;

    public void AttackEnemy(int valmodifier)
    {
        dmgpoints = valmodifier * dmgpoints;
    }

}
