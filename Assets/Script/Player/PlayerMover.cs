using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float moveSpeed = 200f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _rb.AddForce(
            Input.GetAxisRaw("Vertical") * moveSpeed * transform.up,
            ForceMode2D.Impulse)
            
            ;
        
        //if (Input.GetKey(KeyCode.W))
        //{
            //_rb.velocity = new Vector2(0, 10);
        //    _rb.AddForce(Vector2.up * moveSpeed);
        //    Debug.Log("è„");
        //}

        //if(Input.GetKey(KeyCode.S))
        //{
        //    _rb.AddForce(Vector2.down*moveSpeed);
        //    Debug.Log("â∫");

        }

    }
