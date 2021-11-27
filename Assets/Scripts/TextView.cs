using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    //public string input;
    public Text scoreText;

    public void Update()
    {
        scoreText.text = BeerBottles.TotalScore.ToString();        
    }
}
