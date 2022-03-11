using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YESER : MonoBehaviour
{

    public float DieDelay = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, DieDelay);
    }




}
