using System;
using UnityEngine;

public class ContiniousInputFaker : MonoBehaviour, IGiveInput
{

    public event Action OnRightInput;
    public event Action OnJumpInput;


    bool rightInputToggle;
    bool jumpInputToggle;

    public void TestInputRight()
    {
        OnRightInput.Invoke();
    }

    public void TestInputJump()
    {
        OnJumpInput.Invoke();
    }
    public void StartContiniousRightInput()
    {
        rightInputToggle = true;
    }

    public void StopContiniousRightInput()
    {
        rightInputToggle = false;
    }

    public void StartContiniousJumpInput()
    {
        jumpInputToggle = true;
    }

    public void StopContiniousJumpInput()
    {
        jumpInputToggle = false;
    }


    private void Update()
    {
        if(rightInputToggle)
        {
            TestInputRight();
        }
        if(jumpInputToggle)
        {
            TestInputJump();
        }
        
    }
}
