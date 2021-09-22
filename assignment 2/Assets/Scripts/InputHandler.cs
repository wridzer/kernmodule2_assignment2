using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    public List<System.Action> actionList = new List<System.Action>();
    private Dictionary<KeyCode, System.Action> keyCommands = new Dictionary<KeyCode, System.Action>();

    public void AddCommand(KeyCode _key, System.Action _command)
    {
        if (!keyCommands.ContainsKey(_key))
        {
            keyCommands.Add(_key, null);
        }
        keyCommands[_key] = _command;
        actionList.Add(_command);
    }

    public void RemoveCommand(KeyCode _key)
    {
        if (keyCommands.ContainsKey(_key))
        {
            keyCommands.Remove(_key);
        }
    }
    
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

    public void HandleInput()
    {
        foreach (KeyValuePair<KeyCode, System.Action> entry in keyCommands)
        {
            if (Input.GetKey(entry.Key))
            {
                entry.Value();
            }
        }
    }
}
