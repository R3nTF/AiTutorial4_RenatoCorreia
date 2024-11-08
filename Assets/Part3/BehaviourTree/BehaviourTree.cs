using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : Node
{
    public BehaviourTree()
    {
        name = "Tree";

    }

    public BehaviourTree(string n)
    {
        name = n;
    }
}
