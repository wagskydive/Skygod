using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    Rigidbody2D rb;
    CharacterMovementController cm;

    GroundDetector gd;
    Animator animator;

    SpriteRenderer sr;

    public Animator Animator { get => animator; }


    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            animator = gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = Resources.Load("Characters/CrownGuy/PlayerCrowHead") as RuntimeAnimatorController;
        }

        gd = GetComponent<GroundDetector>();
        if (gd == null)
        {
            gd = gameObject.AddComponent<GroundDetector>();
        }

        rb = GetComponent<Rigidbody2D>();


        cm = GetComponent<CharacterMovementController>();
        cm.OnMoveLeft += SetFaceLeft;
        cm.OnMoveRight += SetFaceRight;
        cm.OnJump += SetJumpBool;
        gd.OnIsOnGround += SetOnGround;
        gd.OnIsNotOnGround += SetNotOnGround;


        sr = gameObject.GetComponent<SpriteRenderer>();
        if (sr == null)
        {
            sr = gameObject.AddComponent<SpriteRenderer>();
        }

    }

    private void SetJumpBool()
    {
        animator.SetBool("Jump", true);
        Invoke("UnsetJump", .5f);
    }

    void SetOnGround()
    {
        animator.SetBool("OnGround", true);
    }

    void SetNotOnGround()
    {
        animator.SetBool("OnGround", false);
    }

    void UnsetJump()
    {
        animator.SetBool("Jump", false);
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
        animator.SetFloat("FallSpeed", rb.velocity.y);


    }

}
