using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STAGEBAR : MonoBehaviour
{

    int hit = 0;

    public GameObject BAR1;
    public GameObject BAR2;
    public GameObject BAR3;
    public GameObject BAR4;
    public GameObject BAR5;
    public GameObject BAR6;
    public GameObject BAR7;
    public GameObject BAR8;
    public GameObject BAR9;
    public GameObject BAR10;

    public GameObject small1;
    public GameObject small2;
    public GameObject small3;
    public GameObject small4;
    public GameObject small5;
    public GameObject small6;
    public GameObject small7;

    void Update()
    {



        if (hit >=1)
        {
            BAR1.SetActive(true);
            small1.GetComponent<VIBRATER>().enabled = true;
        }

        if (hit >= 2)
        {
            BAR2.SetActive(true);
            small2.GetComponent<VIBRATER>().enabled = true;

        }

        if (hit >= 3)
        {
            BAR3.SetActive(true);
            small3.GetComponent<VIBRATER>().enabled = true;

        }

        if (hit >= 4)
        {
            BAR4.SetActive(true);
            small4.GetComponent<VIBRATER>().enabled = true;

        }

        if (hit >= 5)
        {
            BAR5.SetActive(true);
            small5.GetComponent<VIBRATER>().enabled = true;

        }

        if (hit >= 6)
        {
            BAR6.SetActive(true);
            small6.GetComponent<VIBRATER>().enabled = true;

        }

        if (hit >= 7)
        {
            BAR7.SetActive(true);
            small7.GetComponent<VIBRATER>().enabled = true;

        }

        if (hit >= 8)
        {
            BAR8.SetActive(true);
            small1.GetComponent<VIBRATER>().xAmount = 2;
            small1.GetComponent<VIBRATER>().yAmount = 2;
            small2.GetComponent<VIBRATER>().xAmount = 2;
            small2.GetComponent<VIBRATER>().yAmount = 2;
            small3.GetComponent<VIBRATER>().xAmount = 2;
            small3.GetComponent<VIBRATER>().yAmount = 2;
            small4.GetComponent<VIBRATER>().xAmount = 2;
            small4.GetComponent<VIBRATER>().yAmount = 2;
            small5.GetComponent<VIBRATER>().xAmount = 2;
            small5.GetComponent<VIBRATER>().yAmount = 2;
            small6.GetComponent<VIBRATER>().xAmount = 2;
            small6.GetComponent<VIBRATER>().yAmount = 2;
            small7.GetComponent<VIBRATER>().xAmount = 2;
            small7.GetComponent<VIBRATER>().yAmount = 2;


        }

        if (hit >= 9)
        {
            BAR9.SetActive(true);
            small1.GetComponent<VIBRATER>().xAmount = 4;
            small1.GetComponent<VIBRATER>().yAmount = 4;
            small2.GetComponent<VIBRATER>().xAmount = 4;
            small2.GetComponent<VIBRATER>().yAmount = 4;
            small3.GetComponent<VIBRATER>().xAmount = 4;
            small3.GetComponent<VIBRATER>().yAmount = 4;
            small4.GetComponent<VIBRATER>().xAmount = 4;
            small4.GetComponent<VIBRATER>().yAmount = 4;
            small5.GetComponent<VIBRATER>().xAmount = 4;
            small5.GetComponent<VIBRATER>().yAmount = 4;
            small6.GetComponent<VIBRATER>().xAmount = 4;
            small6.GetComponent<VIBRATER>().yAmount = 4;
            small7.GetComponent<VIBRATER>().xAmount = 4;
            small7.GetComponent<VIBRATER>().yAmount = 4;
        }

        if (hit >= 10)
        {
            BAR10.SetActive(true);
            small1.GetComponent<VIBRATER>().xAmount = 8;
            small1.GetComponent<VIBRATER>().yAmount = 8;
            small2.GetComponent<VIBRATER>().xAmount = 8;
            small2.GetComponent<VIBRATER>().yAmount = 8;
            small3.GetComponent<VIBRATER>().xAmount = 8;
            small3.GetComponent<VIBRATER>().yAmount = 8;
            small4.GetComponent<VIBRATER>().xAmount = 8;
            small4.GetComponent<VIBRATER>().yAmount = 8;
            small5.GetComponent<VIBRATER>().xAmount = 8;
            small5.GetComponent<VIBRATER>().yAmount = 8;
            small6.GetComponent<VIBRATER>().xAmount = 8;
            small6.GetComponent<VIBRATER>().yAmount = 8;
            small7.GetComponent<VIBRATER>().xAmount = 8;
            small7.GetComponent<VIBRATER>().yAmount = 8;
        }

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {





        if (collision.collider.tag == "YESMANSQUARE")
        {
            hit += 1;


        }
    }

}
