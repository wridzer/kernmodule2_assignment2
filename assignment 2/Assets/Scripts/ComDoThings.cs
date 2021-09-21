using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComDoThings
{
    public ComDoThings(InputHandler inputHandler, KeyCode key)
    {
        inputHandler.AddCommand(key, Execute);
    }

    public void Execute()
    {
        Debug.Log("Doing things!");
    }
}
