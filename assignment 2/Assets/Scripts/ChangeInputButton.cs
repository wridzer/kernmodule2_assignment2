using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInputButton : MonoBehaviour
{
    //This script remaps some buttons using the menubuttons
    /*
    private bool isClicked = false;
    private KeyCode key;
    System.Action action;

    public void OnClickF()
    {
        isClicked = true;
        action = InputSettings.instance.playerMove.Forward;
    }
    public void OnClickB()
    {
        isClicked = true;
        action = InputSettings.instance.playerMove.Backward;
    }
    public void OnClickL()
    {
        isClicked = true;
        action = InputSettings.instance.playerMove.Left;
    }
    public void OnClickR()
    {
        isClicked = true;
        action = InputSettings.instance.playerMove.Right;
    }

    private void CheckInput(System.Action action)
    {
        isClicked = false;
        InputSettings.instance.inputHandler.AddCommand(key, action);
    }

    void OnGUI()
    {
        if (isClicked)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                key = e.keyCode;
                CheckInput(action);
            }
        }
    }*/
}
