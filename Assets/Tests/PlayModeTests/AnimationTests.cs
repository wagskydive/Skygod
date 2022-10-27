using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class AnimationTests
{
    [UnityTest]
    public IEnumerator MovementFloatIsBeingUpdated()
    {
        var gameObject = new GameObject();
        var characterMovementController = gameObject.AddComponent<CharacterMovementController>();
        var characterAnimationController = gameObject.AddComponent<CharacterAnimationController>();


        var inputFaker = gameObject.AddComponent<ContiniousInputFaker>();

        characterMovementController.AssignInput(inputFaker);


        inputFaker.StartContiniousRightInput();

        yield return new WaitForSeconds(.4f);
        Assert.IsTrue(characterAnimationController.Animator.GetFloat("Speed") != 0);
        Assert.AreEqual(characterAnimationController.Animator.GetFloat("Speed"),Mathf.Abs( gameObject.GetComponent<Rigidbody2D>().velocity.x));
        
    }

    [UnityTest]
    public IEnumerator AnimationInvertionIsBeingUpdatedOnMovementChange()
    {
        var gameObject = new GameObject();
        var characterMovementController = gameObject.AddComponent<CharacterMovementController>();
        var characterAnimationController = gameObject.AddComponent<CharacterAnimationController>();


        var inputFaker = gameObject.AddComponent<ContiniousInputFaker>();

        characterMovementController.AssignInput(inputFaker);


        inputFaker.TestInputRight();

        
        
        
        Assert.IsFalse(gameObject.GetComponent<SpriteRenderer>().flipX);

        inputFaker.StartContiniousLeftInput();
        yield return new WaitForSeconds(.4f);
        Assert.IsTrue(gameObject.GetComponent<SpriteRenderer>().flipX);

    }


}
