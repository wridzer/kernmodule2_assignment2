using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;

    // Start is called before the first frame update
    void Start()
    {
        inputHandler = InputSettings.instance.inputHandler;
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
    }

}
