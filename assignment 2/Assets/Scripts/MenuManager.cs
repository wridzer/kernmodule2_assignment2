using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager
{
    //Enables the remapping menu
    private GameObject menuInstance;

    public MenuManager(InputHandler _inputHandler,GameObject _menuInstance,KeyCode _menu)
    {
        _inputHandler.AddCommand(_menu, OpenClose);
        menuInstance = _menuInstance;
    }

    private void OpenClose()
    {
        menuInstance.SetActive(!menuInstance.activeSelf);
    }
}
