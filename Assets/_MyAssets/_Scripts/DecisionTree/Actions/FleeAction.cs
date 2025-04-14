using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Fill in for Lab 7a.
public class FleeAction : ActionNode // Only for ranged combat enemy
{
    public FleeAction()
    {
        name = "Flee Action";
    }

    public override void Action()
    {
        // Enter functionality for action
        if(Agent.GetComponent<AgentObject>().state != ActionState.FLEE)
        {
            Debug.Log("Starting " + name);
            AgentObject ao = Agent.GetComponent<AgentObject>();
            ao.state = ActionState.FLEE;
            // Custom enter actions.
            if(AgentScript is RangedCombatEnemy rce)
            {
                // DO Ranged combat thing
            }
        }
        // Every frame
        Debug.Log("Performing " + name);
    }
}
