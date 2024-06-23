using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{

    public GameObject menuUI;
    public GameObject onGameUI;

    public TMP_Text scoreText;


    private void Start()
    {
        LoadMenuUI();
    }

    public void OnStartGamePressed()
    {
        GameManager.instance.StartGame();
        LoadOnGameUI();
    }

    public void UpdateScoreText(int score)
    {
        scoreText.text = score + "";
    }

    private void LoadOnGameUI()
    {
        onGameUI.SetActive(true);
        menuUI.SetActive(false);
    }

    private void LoadMenuUI()
    {
        onGameUI.SetActive(false);
        menuUI.SetActive(true);
    }



   
}
