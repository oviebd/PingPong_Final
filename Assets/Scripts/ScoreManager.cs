using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int currentScore;


    public int AddScore(int score)
    {
        currentScore += score;
        return currentScore;
    }

    public int ResetScore()
    {
        currentScore = 0;
        return currentScore;
    }


}
