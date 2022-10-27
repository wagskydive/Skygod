using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ScoringTests
{
    [Test]
    public void _ScoringCanBeIncrementedByOne()
    {
        //Assign
        var score = new Score();

        // Act
        score.Add(1);

        // Assert

        Assert.AreEqual(1, score.CurrentScore);

    }

        public void _ScoringCanBeIncrementedByTen()
    {
        //Assign
        var score = new Score();

        // Act
        score.Add(10);

        // Assert

        Assert.AreEqual(10, score.CurrentScore);

    }

    
}
