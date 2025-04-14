using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Fill in for Lab 7a.
public class MoveToRangeAction : ActionNode
{
    public MoveToRangeAction()
    {
        name = "Move To Range Action";
    }

    public override void Action()
    {
        // Enter functionality for action
        if(Agent.GetComponent<AgentObject>().state != ActionState.MOVE_TO_RANGE)
        {
            Debug.Log("Starting " + name);
            AgentObject ao = Agent.GetComponent<AgentObject>();
            ao.state = ActionState.MOVE_TO_RANGE;
            // Custom enter actions.
            if(AgentScript is RangedCombatEnemy rce)
            {
                // DO Ranged Combat Enemy Stuff
            }
        }
        // Every frame
        Debug.Log("Performing " + name);
    }
}
