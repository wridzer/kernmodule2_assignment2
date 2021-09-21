using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private Dictionary<KeyCode, ICommand> keyCommands = new Dictionary<KeyCode, ICommand>();

    public void HandleInput()
    {
        foreach(var KeyCode in keyCommands)
        {
            if (Input.GetKeyDown(KeyCode.Key))
            {
                KeyCode.Value.Execute();
            }
        }
    }

    private void Start()
    {
        ComDoThings DoThings = new ComDoThings();
        keyCommands.Add(KeyCode.E, DoThings);
    }

    //commands interface and classes

    //add and remove commands
}
