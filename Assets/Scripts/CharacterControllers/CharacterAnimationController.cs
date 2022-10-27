using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    Rigidbody2D rb;
    CharacterMovementController cm;
    Animator animator;

    SpriteRenderer sr;

    public Animator Animator{get=>animator;}

    private void Awake() 
    {
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            animator = gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = Resources.Load("Animations/Player") as RuntimeAnimatorController;
        }
        rb = GetComponent<Rigidbody2D>();


        cm = GetComponent<CharacterMovementController>();
        cm.OnMoveLeft += SetFaceLeft;
        cm.OnMoveRight += SetFaceRight;

        sr = gameObject.GetComponent<SpriteRenderer>();
        if(sr == null)
        {
            sr = gameObject.AddComponent<SpriteRenderer>();
        }

    }

    void SetFaceLeft()
    {
        sr.flipX = true;
    }

    void SetFaceRight()
    {
        sr.flipX = false;
    }



    private void FixedUpdate() 
    {
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        
    }

}
