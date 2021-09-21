using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComDoThings : ICommand
{
    public void Execute()
    {
        Debug.Log("Doing things!");
    }
}
