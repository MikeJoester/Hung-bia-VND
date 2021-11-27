using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerUI : MonoBehaviour
{
    public GameObject WinningUI;
    public int PassedScore;
    public Text scoreText;
    public Text HighScore;

    void Update()
    {
        string sc = BeerBottles.TotalScore.ToString();
        scoreText.text = sc;
        if ((BeerBottles.TotalScore == PassedScore) || (BeerBottles.TotalScore > PassedScore))
        {
            HighScore.text = "HIGH SCORE: " + sc;
            WinningUI.SetActive(true);
            Time.timeScale = 0f;
            BeerBottles.life = 3;
            BeerBottles.TotalScore = 0;
        }
    }
}
