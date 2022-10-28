using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreboardScoreText : MonoBehaviour
{
    //�ĴX�W (�Ĥ@�W:0�A�ĤG�W:1�A�ĤT�W:2)
    public int place;

    void Start()
    {
        //��ScoreBoardDataControl�̷ӦW�����o����
        int score = ScoreBoardDataControl.instance.GetScore(place);

        //�Y���Ƥ����s�A��s���ơC���s�h����ܡC
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