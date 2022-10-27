using System;


public class InputFaker : IGiveInput
{
    public event Action OnRightInput;
    public event Action OnJumpInput;


    bool rightInputToggle;

    public void TestInputRight()
    {
        OnRightInput.Invoke();
    }

    public void TestInputJump()
    {
        OnJumpInput.Invoke();
    }
}
