using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovementController : MonoBehaviour
{
    public event Action OnMoveLeft;
    public event Action OnMoveRight;

    Rigidbody2D rb;

    IGiveInput inputGiver;

    public IGiveInput InputGiver{get => inputGiver;}

    [SerializeField]
    float jumpForce = 100;

    [SerializeField]
    float accelerationSpeed = 100;

    [SerializeField]
    float maximumSpeed = 1;

    public float MaximumSpeed {get => maximumSpeed;}

    public void SetMaximumSpeed(float speed)
    {
        maximumSpeed = speed;
    }

    [SerializeField]
    float jumpCoolDownLength = .5f;
    float jumpCoolDown = 0;

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

    private void Update()
    {
        if(jumpCoolDown > 0)
        {
            jumpCoolDown -= Time.deltaTime;
        }
    }
    


    public void AssignInput(IGiveInput newinputGiver)
    {
        inputGiver = newinputGiver;
        inputGiver.OnRightInput += MoveRight;
        inputGiver.OnLeftInput += MoveLeft;
        inputGiver.OnJumpInput += Jump;

    }

    void MoveRight()
    {
        if(rb.velocity.x < maximumSpeed)
        {
            rb.AddForce(Vector2.right * accelerationSpeed);
        }
        OnMoveRight?.Invoke();
    }

    void MoveLeft()
    {
        if(rb.velocity.x*-1 < maximumSpeed)
        {
            rb.AddForce(Vector2.right * -accelerationSpeed);
        }
        OnMoveLeft?.Invoke();
    }


    void Jump()
    {
        if(jumpCoolDown <= 0)
        {
            rb.AddForce(Vector2.up * jumpForce);
            jumpCoolDown = jumpCoolDownLength;
        }
        
    }

}
