using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class SCORES : MonoBehaviour
{

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;

    float limitTime = 12.3f;
    public float currentTime;

    //public GameObject TimerBarAll;

    public Image TimerBar;

    public GameObject FailUI;

    public GameObject gameManager;



    // Start is called before the first frame update
    void Start()
    {
        currentTime = limitTime;
        
    }

    // Update is called once per frame
    void Update()
    {

        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if(GM.yes <5 && !Input.GetKey(KeyCode.P)  )
        {
            currentTime -= 1f * Time.deltaTime;

        }

        float score = currentTime * 1000f;

        timerText.text = score.ToString("0");

        TimerBar.fillAmount = currentTime / limitTime;

        if(currentTime <=0f)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

            FailUI.SetActive(true);
        }
    }
}
