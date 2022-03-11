using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALLMAKER : MonoBehaviour
{

    public Transform firePoint;
    public GameObject Waterball;

    public int ballLinit = 100;
    int ballCount = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();

        //StartCoroutine(FireX());
    }

    public void Fire()
    {
        if (ballCount >= ballLinit) return;


        Instantiate(Waterball, firePoint.position,firePoint.rotation);

        ballCount++;
    }

    IEnumerator FireX()
    {

        Debug.Log("fire");

        //Instantiate(Waterball, firePoint.position, firePoint.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(Waterball, firePoint.position, firePoint.rotation);

        Debug.Log("fireOver");
    }
}
