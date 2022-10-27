using System;
using UnityEngine;


public class InputFaker : IGiveInput
{
    public event Action OnRightInput;

    public void TestInputRight()
    {
        OnRightInput.Invoke();
    }
}
