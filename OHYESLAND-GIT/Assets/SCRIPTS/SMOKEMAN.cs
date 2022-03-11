using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMOKEMAN : MonoBehaviour
{

    public float amount = 1f;

    public float cigar_amount;

    public Transform cigar;

    public Transform cigarCut;

    public GameObject Normal;
    public GameObject Anger;

    GameObject gm;

    AudioSource sfx1;

    bool isHurt = false;

    // Start is called before the first frame update
    void Start()
    {
        cigar = gameObject.transform.Find("CIGAR");

        sfx1 = GetComponent<AudioSource>();

        //cigarCut = gameObject.transform.Find("CIGARCUT");

        gm = GameObject.FindGameObjectWithTag("GAMEMANAGER");

    }

    // Update is called once per frame
    void Update()
    {
        GAMEMANAGER GM = gm.GetComponent<GAMEMANAGER>();


        Shaking();

        ShakingCigar();

        if(GM.yes >=5)
        {
            cigar.gameObject.SetActive(false);
            cigarCut.gameObject.SetActive(true);

            Normal.SetActive(false);
            Anger.SetActive(true);

            if(!sfx1.isPlaying && isHurt == false)
            {
                sfx1.Play();
                isHurt = true;
            }
        }
    }

    void Shaking()
    {
        Vector3 originalPos = transform.position;

        float x = Random.Range(-1f, 1f) * amount;
        float y = Random.Range(-1f, 1f) * amount;

        transform.position = new Vector3(originalPos.x + x, originalPos.y, transform.position.z);
    }

    void ShakingCigar()
    {


        Vector3 cigarPos = cigar.transform.position;

        float x = Random.Range(-1f, 1f) * cigar_amount;

        cigar.transform.position = new Vector3(cigarPos.x + x, cigarPos.y, transform.position.z);

        
    }
}
