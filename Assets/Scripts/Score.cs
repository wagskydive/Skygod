using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public int CurrentScore {get; private set;}

    public Score()
    {
        CurrentScore = 0;
    }

    public void Add(int amount)
    {
        CurrentScore+=amount;
    }

}
