using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_obj : MonoBehaviour
{

    public float speed;

    Transform L_position;
    Transform R_position;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        L_position.transform.position = new Vector3(-6, -0.842f, 0);
        R_position.transform.position = new Vector3(6, -0.842f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(L_position.position,R_position.position,step);
        //Vector2.MoveTowards()
    }
}
