using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Fill in for Lab 7a.
public class MoveToLOSAction : ActionNode
{
    public MoveToLOSAction()
    {
        name = "Move to LOS Action";
    }

    public override void Action()
    {
        // Enter functionality for agent.
        if(Agent.GetComponent<AgentObject>().state  != ActionState.MOVE_TO_LOS)
        {
            Debug.Log("Starting " + name);
            AgentObject ao = Agent.GetComponent<AgentObject>();
            ao.state = ActionState.MOVE_TO_LOS;
            // Custom enter actions
            if(AgentScript is CloseCombatEnemy cce)
            {
                // do closed combat thing
            }
            else if(AgentScript is RangedCombatEnemy rce)
            {
                
                // do ranged combat things
            }
        }
        // every frame
        Debug.Log("Performing " + name);
    }
}
