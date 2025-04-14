using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Fill in for Lab 7a.
public class RangedCombatCondition : ConditionNode
{
    public bool IsWithinCombatRange { get; set; }

    public RangedCombatCondition()
    {
        name = "Ranged Combat Condition";
        IsWithinCombatRange = false;
    }

    public override bool Condition()
    {
        Debug.Log("Checking " + name);
        //DO the checking condition stuff
        return IsWithinCombatRange;
    }
}
