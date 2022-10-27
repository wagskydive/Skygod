using System;


public class InputFaker : IGiveInput
{
    public event Action OnRightInput;

    public event Action OnLeftInput;
    public event Action OnJumpInput;


    bool rightInputToggle;

    public void TestInputRight()
    {
        OnRightInput.Invoke();
    }

    public void TestInputLeft()
    {
        OnLeftInput.Invoke();
    }

    public void TestInputJump()
    {
        OnJumpInput.Invoke();
    }
}
