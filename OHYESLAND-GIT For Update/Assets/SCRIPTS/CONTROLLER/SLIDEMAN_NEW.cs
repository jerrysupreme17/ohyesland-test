using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SLIDEMAN_NEW : MonoBehaviour
{

    Cube_Control controls;
    Vector2 move;
    Rigidbody2D rb;

    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        controls = new Cube_Control();

        controls.YES_CUBE.MOVE.performed += ctx => move = ctx.ReadValue<Vector2>();
    }


    private void Update()
    {
        Vector2 m = new Vector2(-move.x, move.y) * Time.deltaTime;
        rb.velocity = m * speed;
    }

    private void OnEnable()
    {
        controls.YES_CUBE.Enable();
    }

    private void OnDisable()
    {
        controls.YES_CUBE.Disable();
    }
}
