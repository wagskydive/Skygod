using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementController : MonoBehaviour
{
    Rigidbody2D rb;

    IGiveInput inputGiver;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        if(rb == null) 
        {
            rb = gameObject.AddComponent<Rigidbody2D>();

        }
        if(inputGiver == null)
        {
            IGiveInput newInputGiver = gameObject.AddComponent<KeyboardInputHandler>();
            AssignInput(newInputGiver);
        }
        
    }
    
    public void AssignInput(IGiveInput newinputGiver)
    {
        inputGiver = newinputGiver;
        inputGiver.OnRightInput += MoveRight;
        inputGiver.OnJumpInput += Jump;

    }

    void MoveRight()
    {
        transform.position += Vector3.right;
    }

    
    void Jump()
    {
        rb.AddForce(Vector2.up * 100);
    }

}
