using System.Collections;
using System.Collections.Generic;
using BehaviorTree;
using UnityEngine;

namespace BehaviorTree
{
    public class GoToDrink : Node
    {
        
        
        public override NodeState Evaluate()
        {
            return NodeState.RUNNING;
        }
    }
}
