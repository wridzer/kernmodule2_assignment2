using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;

    // Start is called before the first frame update
    void Start()
    {
        inputHandler = new InputHandler();
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
    }
}
