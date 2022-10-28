using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreboardScoreText : MonoBehaviour
{
    //第幾名 (第一名:0，第二名:1，第三名:2)
    public int place;

    void Start()
    {
        //由ScoreBoardDataControl依照名次取得分數
        int score = ScoreBoardDataControl.instance.GetScore(place);

        //若分數不為零，更新分數。為零則不顯示。
        if (score != 0)
        {
            GetComponent<Text>().text = score.ToString() + "cm";
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}