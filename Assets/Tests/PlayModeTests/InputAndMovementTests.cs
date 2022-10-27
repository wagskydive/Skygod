using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class InputAndMovement
{

    [UnityTest]
    public IEnumerator MoveRight()
    {
        var gameObject = new GameObject();
        var characterMovementController = gameObject.AddComponent<CharacterMovementController>();

        float spawnXpos = gameObject.transform.position.x;

        var inputFaker = new InputFaker();

        characterMovementController.AssignInput(inputFaker);


        inputFaker.TestInputRight();

        yield return new WaitForSeconds(1);

        Assert.IsTrue(spawnXpos < gameObject.transform.position.x);
    }
    
}
