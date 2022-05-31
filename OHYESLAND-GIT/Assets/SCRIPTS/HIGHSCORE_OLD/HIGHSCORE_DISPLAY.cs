using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HIGHSCORE_DISPLAY: MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    public void DisplayHighScore(string name, float score)
    {
        float theScore = STATIC_SCORE.allScore;
        string theName = STATIC_SCORE.playerName;
        PlayerPrefs.SetFloat("SCORE", theScore);
        PlayerPrefs.SetString("NAME", theName);

        nameText.text = name;
        scoreText.text = score.ToString("0");
        //nameText.text = PlayerPrefs.GetString("NAME");
        //scoreText.text = PlayerPrefs.GetFloat("SCORE").ToString("0");
    }
    public void HideEntryDisplay()
    {
        nameText.text = "";
        scoreText.text = "";
    }
}
