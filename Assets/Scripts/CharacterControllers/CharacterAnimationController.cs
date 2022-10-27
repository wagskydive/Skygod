using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    Rigidbody2D rb;
    Animator animator;

    public Animator Animat{get=>animator;}

    private void Awake() 
    {
        animator = GetComponent<Animator>();
        if(animator == null)
        {
            animator = gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = Resources.Load("Animations/Player") as RuntimeAnimatorController;
        }
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate() 
    {
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }

}
