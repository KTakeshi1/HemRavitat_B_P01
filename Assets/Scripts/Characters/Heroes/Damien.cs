using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damien : MonoBehaviour
{
     public int hitpoints = 20;
     public int currenthitpoints = 20;
    public int dmgpoints = 5;

    public void AttackEnemy(int valmodifier)
    {
        dmgpoints = valmodifier + dmgpoints;
    }

}
