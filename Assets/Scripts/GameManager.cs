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
        environmentManager.OnGameStart();

        int currentScore = scoreManager.ResetScore();
        uiManager.UpdateScoreText(currentScore);
    }

    public void GameEnd()
    {
        environmentManager.OnGameOver();
        uiManager.OnGameOver();
    }

    public void IncrementScore(int score)
    {
        int currentScore = scoreManager.AddScore(score);
        uiManager.UpdateScoreText(currentScore);
    }
}
