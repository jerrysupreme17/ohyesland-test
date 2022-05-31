using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIGHSCORE_ENTRY
{
    public string name;
    public float score;

    public void Awake()
    {
        name = STATIC_SCORE.playerName;
        score = STATIC_SCORE.allScore;
    }
}
