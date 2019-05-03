using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Text startText;
    [SerializeField] private Text scoreText;
    private int score;

    public void showTittleScreen()
    {
        startText.text = "PRESS SPACE";
        scoreText.text = "";
    }

    public void hideTittleScreen()
    {
        startText.text = "";
        scoreText.text = "Score: 0";
    }

    public void UpdateScore()
    {
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
