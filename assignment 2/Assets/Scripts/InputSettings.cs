using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSettings : MonoBehaviour
{
    [SerializeField] private GameObject playerInstance;
    public InputHandler inputHandler;
    public static InputSettings instance;
    public Moveable playerMove;

    [Header("Keybindings")]
    [SerializeField] private KeyCode forward = KeyCode.W;
    [SerializeField] private KeyCode backward = KeyCode.S;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode right = KeyCode.D;


    private void Start()
    {
        inputHandler = new InputHandler();
        instance = this;
        playerMove = new Moveable(inputHandler, playerInstance, forward, backward, left, right);
    }
}
