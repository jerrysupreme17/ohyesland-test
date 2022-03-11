using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEMANAGER : MonoBehaviour
{
    //public GameObject object1;
    //public GameObject object2;
    //public GameObject object3;
    //public GameObject object4;
    //public GameObject object5;// �o�̥u�O���]�ڻݭn�@�ӭӧ������ӷ��@�L�����P�_


    public int yes = 0; // �i��|�Ψ�
    public GameObject CompleteUI;

    public GameObject FailUI;

    public GameObject PauseUI;

     GameObject TimerBar;

    

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);

        TimerBar = GameObject.FindGameObjectWithTag("TIMERBAR");
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKey(KeyCode.O))
        {
            LoadNextScene();
        }

        if (Input.GetKey(KeyCode.I))
        {
            LoadPreviosScene();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            //Application.LoadLevel(Application.loadedLevel);

            Reload();

        }

        if(Input.GetKey(KeyCode.Escape))
        {
            EndGame();
        }

        if(Input.GetKey(KeyCode.M))
        {
            LoadMap();
        }

        if(yes >=5 && !FailUI.activeSelf)
        {
            CompleteUI.SetActive(true);


        }

        if (yes <=-5 && !CompleteUI.activeSelf)
        {
            FailUI.SetActive(true);

        }

        /*if(CompleteUI.activeSelf || FailUI.activeSelf)
        {
            TimerBar.SetActive(false);
        }
        */

    }

    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;

    }

    public void EndGame()
    {
        Application.Quit();

    }

    public void Complete()
    {

        yes += 1;
    }

    public void Lose()
    {
        FailUI.SetActive(true);
    }

    public void Win()
    {
        yes += 5;
    }


    public void LoadPreviosScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MENU");
    }

    public void LoadMap()
    {
        SceneManager.LoadScene("MAP");
    }

    public void Loadlevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void Loadlevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void Loadlevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void Loadlevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void Loadlevel5()
    {
        SceneManager.LoadScene(5);
    }

    public void Loadlevel6()
    {
        SceneManager.LoadScene(6);
    }

    public void Loadlevel7()
    {
        SceneManager.LoadScene(7);
    }

    public void Loadlevel8()
    {
        SceneManager.LoadScene(8);
    }


}