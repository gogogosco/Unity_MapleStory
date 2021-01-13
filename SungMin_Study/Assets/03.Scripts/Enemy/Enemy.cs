using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private State currentState;
    private float defaultPosition;
    public float Enemy_defaultPostion { get { return defaultPosition; } }

    void Start()
    {
        defaultPosition = this.transform.position.x;
        SetState(new MoveRight());
    }

    void Update()
    {
        currentState.Update();
    }

    public void SetState(State nextState)
    {
        if(currentState != null)
        {
            currentState.OnExit();
        }
        currentState = nextState;
        currentState.OnEnter(this);
    }
}
