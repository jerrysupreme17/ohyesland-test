using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VIBRATER : MonoBehaviour
{
    // Start is called before the first frame update

    public float xAmount =1;
    public float yAmount =1;

    public float speed = 5f;
    float intensity =0.05f;

    Vector2 startPos;
    void Start()
    {
        startPos.x = transform.position.x;
        startPos.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(1, -1) * xAmount;
        float y = Random.Range(1, -1) * yAmount;

        transform.localPosition = intensity * new Vector3(x, y, transform.localPosition.z);



        }


            

    }

