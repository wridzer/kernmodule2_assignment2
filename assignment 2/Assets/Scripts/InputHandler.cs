using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    public List<System.Action> actionList = new List<System.Action>();
    private Dictionary<KeyCode, System.Action> keyCommands = new Dictionary<KeyCode, System.Action>();

    //Add commands with keys
    public void AddCommand(KeyCode _key, System.Action _command)
    {
        if (!keyCommands.ContainsKey(_key))
        {
            keyCommands.Add(_key, null);
        }
        keyCommands[_key] = _command;
        actionList.Add(_command);
    }

    //Remove command by key
    public void RemoveCommand(KeyCode _key)
    {
        if (keyCommands.ContainsKey(_key))
        {
            keyCommands.Remove(_key);
        }
    }
    
    //remove command by command
    public void RemoveCommand(System.Action _command)
    {
        foreach (KeyValuePair<KeyCode, System.Action> entry in keyCommands)
        {
            if (entry.Value == _command)
            {
                keyCommands.Remove(entry.Key);
            }
        }
    }

    //Execute the commands
    public void HandleInput()
    {
        foreach (KeyValuePair<KeyCode, System.Action> entry in keyCommands)
        {
            if (Input.GetKeyDown(entry.Key))
            {
                entry.Value();
            }
        }
    }
}
