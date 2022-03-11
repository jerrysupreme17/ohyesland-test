using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SHOOTER_NEW : MonoBehaviour
{


    PlayerController controls;
    Vector2 move;

    public Transform firePoint;

    public GameObject bullet;

    public float speed;

    private void Awake()
    {
        controls = new PlayerController();

        controls.GamePlay.Shoot.performed += ctx => Shoot();

        controls.GamePlay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GamePlay.Move.canceled += ctx => move = Vector2.zero;
    }


    private void OnEnable()
    {
        controls.GamePlay.Enable();
    }

    private void OnDisable()
    {
        controls.GamePlay.Disable();
    }
    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        //Instantiate(FX, new Vector2(firePoint.position.x, firePoint.position.y + offset), firePoint.rotation);
    }

    private void Update()
    {
        Vector2 m = new Vector2(move.x, 0) * Time.deltaTime * speed;
        transform.Translate(m, Space.World);
    }


}
