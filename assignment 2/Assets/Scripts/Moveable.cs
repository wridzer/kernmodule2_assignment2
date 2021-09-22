using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable
{
    private GameObject agent;

    public Moveable(InputHandler _inputHandler, GameObject _agent, KeyCode _forward, KeyCode _backward, KeyCode _left, KeyCode _right)
    {
        agent = _agent;
        _inputHandler.AddCommand(_forward, Forward);
        _inputHandler.AddCommand(_backward, Backward);
        _inputHandler.AddCommand(_left, Left);
        _inputHandler.AddCommand(_right, Right);
    }

    public void Forward()
    {
        agent?.transform.Translate(new Vector3(1, 0, 0));
    }
    public void Backward()
    {
        agent?.transform.Translate(new Vector3(-1, 0, 0));
    }
    public void Left()
    {
        agent?.transform.Translate(new Vector3(0, 0, 1));
    }
    public void Right()
    {
        agent?.transform.Translate(new Vector3(0, 0, -1));
    }
}
