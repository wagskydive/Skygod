using System;
using System.Collections.Generic;
using UnityEngine;

public interface IGiveInput 
{
    public event Action OnRightInput;

    public event Action OnLeftInput;

    public event Action OnJumpInput;
}
