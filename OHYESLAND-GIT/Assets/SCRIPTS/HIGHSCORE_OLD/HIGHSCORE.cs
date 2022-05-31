using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HIGHSCORE : MonoBehaviour
{
    public HIGHSCORE_DISPLAY[] highScoreDisplayArray;
    List<HIGHSCORE_ENTRY> scores = new List<HIGHSCORE_ENTRY>();

    List<PlayerPrefs> playerPrefs = new List<PlayerPrefs>();

    HIGHSCORE_ENTRY hIGHSCORE_ENTRY;
   
    public STATIC_SCORE[] static_score;
    void Start()
    {

        
        

        float theScore = STATIC_SCORE.allScore;
        string theName = STATIC_SCORE.playerName;
        PlayerPrefs.SetFloat("SCORE", theScore);
        PlayerPrefs.SetString("NAME", theName);
        PlayerPrefs.Save();
        // Adds some test data
        AddNewScore("邪惡先生", 100000);
        AddNewScore("飛隼隊長", 40000);
        AddNewScore("THE BIKEMAN", 90000);
        AddNewScore("THE BALL", 60000);
        AddNewScore("SOHB", 500);
        AddNewScoreX(PlayerPrefs.GetString("NAME"), PlayerPrefs.GetFloat("SCOORE"));
       

        //hIGHSCORE_ENTRY.Awake();
        
    }

    private void Update()
    {
       

    }
    void UpdateDisplay()
    {
        scores.Sort((HIGHSCORE_ENTRY x, HIGHSCORE_ENTRY y) => y.score.CompareTo(x.score));
        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(scores[i].name, scores[i].score);
            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
            }
        }
    }
    void AddNewScore(string entryName, int entryScore)
    {
        scores.Add(new HIGHSCORE_ENTRY { name = entryName, score = entryScore });
    }
    void AddNewScoreX(string entryName, float entryScore)
    {
        scores.Add(new HIGHSCORE_ENTRY { name = PlayerPrefs.GetString("NAME"), score = PlayerPrefs.GetFloat("SCORE") });
    }
    
    public void BackToMenu()
    {
        STATIC_SCORE.allScore = 0f;
        STATIC_SCORE.playerName = null;
        SceneManager.LoadScene(0);
    }
}
