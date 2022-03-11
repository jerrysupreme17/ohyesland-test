using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHILD : MonoBehaviour
{


    public float amount = 1f;

    Transform ballon;
    Transform angry;


   

    // Start is called before the first frame update
    void Start()
    {
        ballon = this.gameObject.transform.Find("BALLON");
        angry = this.gameObject.transform.Find("ANGRY");
    }

    // Update is called once per frame
    void Update()
    {



        if(ballon.gameObject.activeSelf == true)
        {
            Shaking();
        }
        else
        {
           // angry.gameObject.SetActive(true);
        }

    }

    void Shaking()
    {
        Vector3 originalPos = transform.position;

        float x = Random.Range(-1f, 1f) * amount;
        float y = Random.Range(-1f, 1f) * amount;

        transform.position = new Vector3(originalPos.x + x, originalPos.y, transform.position.z);
    }
}
