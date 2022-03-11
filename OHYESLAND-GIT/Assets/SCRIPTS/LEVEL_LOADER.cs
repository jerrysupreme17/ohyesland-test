using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LEVEL_LOADER : MonoBehaviour
{

    public float animationTime = 3f;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadNextLevel()
    {
        StartCoroutine(Load());
    }

    public IEnumerator Load()
    {
        animator.SetBool("NEXT", true);

        yield return new WaitForSeconds(animationTime);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
