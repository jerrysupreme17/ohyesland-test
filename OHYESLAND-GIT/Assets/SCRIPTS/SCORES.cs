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

    public float limitTime = 12.3f;
    public float currentTime;

    //public GameObject TimerBarAll;

    public Image TimerBar;

    public GameObject FailUI;

    public GameObject gameManager;

    bool count = true;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = limitTime;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(SceneManager.GetActiveScene().name == "B5 ESCAPE" || SceneManager.GetActiveScene().name == "Z FINAL" || SceneManager.GetActiveScene().name == "F_B5")
        {
            count = false;
        }

        GAMEMANAGER GM = gameManager.GetComponent<GAMEMANAGER>();

        if(GM.yes <5 && !Input.GetKey(KeyCode.P) && count == true )
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
