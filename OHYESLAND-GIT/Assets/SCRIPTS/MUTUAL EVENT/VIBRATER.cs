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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(1, -1) * xAmount;
        float y = Random.Range(1, -1) * yAmount;

        transform.localPosition = intensity * new Vector3(x, y, transform.localPosition.z);


        //transform.localPosition = intensity * new Vector3(
        //    Mathf.PerlinNoise(speed * Time.deltaTime, 1),
        //    Mathf.PerlinNoise(speed * Time.deltaTime, 2),
        //    Mathf.PerlinNoise(speed * Time.deltaTime, 3));
        }


            

    }

