using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MUSICBOX : MonoBehaviour
{
    public AudioSource TitleSong;

    public AudioSource ArcadeSong;

    public AudioSource EndSong;

    // Start is called before the first frame update


    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("MUSICBOX");
            
        if(objs.Length >1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);


    }
    void Start()
    {
    }


    public void Update()
    {

        /*Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if(sceneName == "MENU")
        {
            TitleMode();
        } */

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            TitleMode();
        }
        else if(SceneManager.GetActiveScene().name =="10 ARCADE END")
        {
            EndMode();
        }
        else
            ArcadeMode();

    }

    // Update is called once per frame


    public void ArcadeMode()
    {

        if (!ArcadeSong.isPlaying)
        {
            TitleSong.Stop();
            EndSong.Stop();

            ArcadeSong.Play();
        }
    }

    public void TitleMode()
    {
        if (!TitleSong.isPlaying)
        {
            ArcadeSong.Stop();
            EndSong.Stop();

            TitleSong.Play();
        }
    }

    public void EndMode()
    {
        if (!EndSong.isPlaying)
        {
            ArcadeSong.Stop();
            EndSong.Play();
        }
    }


}
