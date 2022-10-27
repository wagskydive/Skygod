using System;
using UnityEngine;

public class ContiniousInputFaker : MonoBehaviour, IGiveInput
{

    public event Action OnRightInput;

    public event Action OnLeftInput;
    public event Action OnJumpInput;


    bool rightInputToggle;
    bool leftInputToggle;
    bool jumpInputToggle;

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
    public void StartContiniousRightInput()
    {
        rightInputToggle = true;
    }

    public void StopContiniousRightInput()
    {
        rightInputToggle = false;
    }

    public void StartContiniousLeftInput()
    {
        leftInputToggle = true;
    }

    public void StopContiniousLeftInput()
    {
        leftInputToggle = false;
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
        if(leftInputToggle)
        {
            TestInputLeft();
        }
        if(jumpInputToggle)
        {
            TestInputJump();
        }
        
    }


}
