using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;
    [SerializeField] private Dictionary<KeyCode, System.Action> inputToAdd = new Dictionary<KeyCode, System.Action>();
    [SerializeField] private GameObject playerInsance;

    // Start is called before the first frame update
    void Start()
    {
        inputHandler = new InputHandler();
        ComDoThings DoThing = new ComDoThings(inputHandler, KeyCode.E);
    }

    // Update is called once per frame
    void Update()
    {
        inputHandler.HandleInput();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputHandler.RemoveCommand(KeyCode.E);
        }
    }

}
