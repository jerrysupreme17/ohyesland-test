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

    public GameObject VeryGoodText;

    public GameObject GoodText;

    public GameObject DecentText;

    public GameObject BadText;

    public GameObject VeryBadText;


    float FunScore =0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float finalScore = STATIC_SCORE.allScore;

        if(FunScore < finalScore)
        {
            FunScore+=83;
        }
        else
        {

        }

        EndScoreText.text = FunScore.ToString("0");


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
        

        if(finalScore > 57000)
        {
            VeryGoodText.SetActive(true);
        }

        if (finalScore < 57000 && finalScore > 48000)
        {
            GoodText.SetActive(true);
        }
        else if (finalScore < 48000 && finalScore > 35000)
        {
            DecentText.SetActive(true);
        }
        else if (finalScore < 35000 && finalScore > 20000)
        {
            BadText.SetActive(true);
        } 
        else if (finalScore < 20000)
        {
            VeryBadText.SetActive(true);
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);

        STATIC_SCORE.allScore = 0;
    }
}
