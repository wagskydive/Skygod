using System;
using UnityEngine;


public class InputFaker : IGiveInput
{
    public event Action OnRightInput;
    public event Action OnJumpInput;

    public void TestInputRight()
    {
        OnRightInput.Invoke();
    }

    public void TestInputJump()
    {
        OnJumpInput.Invoke();
    }
}
