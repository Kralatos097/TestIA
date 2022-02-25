using System;using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public class Node
    {
        protected NodeState state;

        private Node _parent;
        protected List<Node> children = new List<Node>();

        public Node()
        {
            _parent = null;
        }

        public Node(List<Node> children)
        {
            foreach (Node child in children)
                _Attach(child);
        }

        private void _Attach(Node node)
        {
            node._parent = this;
            children.Add(node);
        }

        public virtual NodeState Evaluate() => NodeState.FAILURE;
    }

    public enum NodeState
    {
        RUNNING,
        SUCCESS,
        FAILURE,
    };
}
