using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Fill in for Lab 7a.
public class HitCondition : ConditionNode
{
    public bool IsHit { get; set; }

    public HitCondition()
    {
        name = "Hit Condition";
        IsHit = false;
    }

    public override bool Condition()
    {
        Debug.Log("Checking " + name);
        //DO the checking condition stuff
        return IsHit;
    }
}
