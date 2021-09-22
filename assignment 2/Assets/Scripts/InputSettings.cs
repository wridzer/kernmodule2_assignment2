using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSettings : MonoBehaviour
{
    //This script does all the input and implements the default settings

    [SerializeField] private GameObject playerInstance;
    [SerializeField] private GameObject menuInstance;
    public InputHandler inputHandler;
    public static InputSettings instance;
    public Moveable playerMove;

    [Header("Keybindings")]
    [SerializeField] private KeyCode forward = KeyCode.W;
    [SerializeField] private KeyCode backward = KeyCode.S;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private KeyCode menu = KeyCode.Escape;


    private void Start()
    {
        inputHandler = new InputHandler();
        instance = this;
        playerMove = new Moveable(inputHandler, playerInstance, forward, backward, left, right);
        MenuManager menuManager = new MenuManager(inputHandler, menuInstance, menu);
    }
}
