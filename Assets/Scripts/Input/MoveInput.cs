using UnityEngine;
using System;

public class MoveInput : Singleton<MoveInput>
{
    [SerializeField] private float minDeltaMagnitude;

    public event Action<Vector2> OnMoveInput;

    private Touch lastTouch;

    private void Update()
    {     
        HandleTouchInput();
    }

    private void HandleTouchInput()
    {
        if (Input.touchCount != 1) return;

        Touch touch = Input.GetTouch(0);

        if(touch.phase == TouchPhase.Began)
        {
            lastTouch = touch;
            return;
        }

        if(touch.phase == TouchPhase.Moved)
        {
            Vector2 delta = touch.position - lastTouch.position;
            if(delta.magnitude >= minDeltaMagnitude)
            {
                CallOnMoveInput(delta);
            }          
            return;
        }
    }

    private void CallOnMoveInput(Vector2 delta)
    {
        if (OnMoveInput != null) OnMoveInput(delta);
    }
}