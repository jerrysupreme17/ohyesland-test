using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ARCADE_END : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI EndScoreText;

    public TextMeshProUGUI RankText;

    public TextMeshProUGUI PlayerText;

    public GameObject VeryGoodText;

    public GameObject GoodText;

    public GameObject DecentText;

    public GameObject BadText;

    public GameObject VeryBadText;

    public float BottonRank;
    public float LowRank;
    public float MidRank;
    public float HighRank;


    float FunScore =0;
    public float Score_speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float finalScore = STATIC_SCORE.allScore;

        string PlayerName = STATIC_SCORE.playerName;

       

        if (FunScore < finalScore)
        {
            FunScore+=Score_speed;
        }
        else
        {

        }

        EndScoreText.text = FunScore.ToString("0");
        PlayerText.text = PlayerName;


        //EndScoreText.text = finalScore.ToString("0");



        /*if(finalScore >38000)
        {
            RankText.text = "天呀！ 你真是奧耶斯大師！";
        }
        else if (finalScore<38000 || finalScore < 22000)
        {
            RankText.text = "玩得不錯，你真是奧耶斯能手～";
        }
        else if (finalScore <22000)
        {
            RankText.text = "還有進步空間，現在我稱你為奧耶斯學徒。";
        } */
        

        if(finalScore > HighRank)
        {
            VeryGoodText.SetActive(true);
        }

        if (finalScore < HighRank && finalScore > MidRank)
        {
            GoodText.SetActive(true);
        }
        else if (finalScore < MidRank && finalScore > LowRank)
        {
            DecentText.SetActive(true);
        }
        else if (finalScore < LowRank && finalScore > BottonRank)
        {
            BadText.SetActive(true);
        } 
        else if (finalScore < BottonRank)
        {
            VeryBadText.SetActive(true);
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);

        STATIC_SCORE.allScore = 0;
    }

    public void ToRanking()
    {
        SceneManager.LoadScene(35);
    }
}
