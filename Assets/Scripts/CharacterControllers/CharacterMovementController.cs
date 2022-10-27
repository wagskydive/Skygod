using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    public void AssignInput(IGiveInput inputGiver)
    {
        inputGiver.OnRightInput += MoveRight;

    }

    void MoveRight()
    {
        transform.position += Vector3.right;
    }

}
