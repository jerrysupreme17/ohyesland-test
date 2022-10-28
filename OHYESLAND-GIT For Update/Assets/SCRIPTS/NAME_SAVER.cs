using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NAME_SAVER : MonoBehaviour
{

    public TextMeshProUGUI InputData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        
        string PlayerName = InputData.text;
        STATIC_SCORE.playerName= PlayerName;

        

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
