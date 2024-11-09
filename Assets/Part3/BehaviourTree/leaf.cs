using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaf : Node
{
    public delegate Status Tick();
    public Tick ProcessMethod;

    public leaf() { }

    public leaf(string n, Tick pm)
    {
        name = n;
        ProcessMethod = pm;
    }

    public override Status Process()
    {
        if(ProcessMethod != null)
            return ProcessMethod();
        return Status.FAILURE;
    }
}
