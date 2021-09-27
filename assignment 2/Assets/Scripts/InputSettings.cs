using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSettings
{
    //This script does all the input and implements the default settings
    public KeyCode forward = KeyCode.W;
    public KeyCode backward = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode menu = KeyCode.Escape;

    private InputHandler inputHandler;

    InputSettings(InputHandler _inputHandler)
    {
        inputHandler = _inputHandler;
    }

    private void start()
    {
        inputHandler.AddCommand(forward, EventType.MOVE_FORWARDS);
    }
}
