using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX_QUICK : MonoBehaviour
{
    // Start is called before the first frame update

    public float ShowTime;
    void Start()
    {
        Destroy(gameObject, ShowTime);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
