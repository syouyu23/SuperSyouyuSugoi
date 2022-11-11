using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_scr : MonoBehaviour
{
    public float speed = 10.0f;
    public float minSpeed =10.0f;
    public float maxSpeed = 20.0f;


    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.AddForce( new Vector2(speed, speed));



    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        float clampSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        rb.velocity = velocity.normalized * clampSpeed;

        

    }
}
