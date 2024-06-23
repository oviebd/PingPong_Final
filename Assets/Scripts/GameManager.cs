using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameEnvironmentManager environmentManager;
    public UiManager uiManager;
    public ScoreManager scoreManager;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void StartGame()
    {
        environmentManager.SpawnBall();
        environmentManager.SpawnObstacle();

        int currentScore = scoreManager.ResetScore();
        uiManager.UpdateScoreText(currentScore);
    }

    public void GameEnd()
    {

    }

    public void IncrementScore(int score)
    {
        int currentScore = scoreManager.AddScore(score);
        uiManager.UpdateScoreText(currentScore);
    }
}
