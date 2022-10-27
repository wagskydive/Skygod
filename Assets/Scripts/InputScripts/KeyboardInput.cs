using System;
using UnityEngine;

public class KeyboardInputHandler : MonoBehaviour, IGiveInput
{
    public event Action OnRightInput;
    public event Action OnJumpInput;

    private void FixedUpdate() 
    {
        if(Input.GetKey(KeyCode.D))
        {
            OnRightInput.Invoke();
        }

        if(Input.GetKey(KeyCode.Space))
        {
            OnJumpInput.Invoke();
        }
    }

}

