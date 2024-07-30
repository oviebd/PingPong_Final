using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{

    public GameObject menuUI;
    public GameObject scoreUI;

    public TMP_Text scoreText;


    private void Start()
    {
        LoadMenuUI();
    }

    public void OnStartGamePressed()
    {
        GameManager.instance.StartGame();
        LoadScoreUI();
    }

    public void OnGameOver()
    {
        LoadMenuUI();
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = score + "";
    }

    private void LoadScoreUI()
    {
        scoreUI.SetActive(true);
        menuUI.SetActive(false);
    }

    private void LoadMenuUI()
    {
        scoreUI.SetActive(false);
        menuUI.SetActive(true);
    }



   
}
