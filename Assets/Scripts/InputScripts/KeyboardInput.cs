using System;
using UnityEngine;

public class KeyboardInputHandler : MonoBehaviour, IGiveInput
{
    public event Action OnRightInput;
    public event Action OnLeftInput;
    public event Action OnJumpInput;

    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.D))
        {
            OnRightInput.Invoke();
        }

        if(Input.GetKey(KeyCode.A))
        {
            OnLeftInput.Invoke();
        }

        if(Input.GetKey(KeyCode.Space))
        {
            OnJumpInput.Invoke();
        }
    }

}

