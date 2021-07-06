using UnityEngine;
using System;

public class ZoomInput : Singleton<ZoomInput>
{
    public event Action<float> OnZoomInput;

    private float lastTouchDistance;

    private void Awake()
    {
        lastTouchDistance = 0;
    }

    private void Update()
    {
        HandleZoomInput();
    }

    private void HandleZoomInput()
    {
        if (Input.touchCount != 2) return;

        Touch touch1, touch2;

        touch1 = Input.GetTouch(0);
        touch2 = Input.GetTouch(1);

        if(touch1.phase == TouchPhase.Began || touch2.phase == TouchPhase.Began)
        {
            lastTouchDistance = Vector2.Distance(touch1.position, touch2.position);
            return;
        }
        
        if(touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
        {
            float distance = Vector2.Distance(touch1.position, touch2.position);
            CallOnZoomInput(lastTouchDistance - distance);
            return;
        }
    }

    private void CallOnZoomInput(float delta)
    {
        if(OnZoomInput != null) OnZoomInput(delta);
    }
}