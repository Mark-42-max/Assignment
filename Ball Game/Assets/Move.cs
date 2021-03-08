using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    new Rigidbody2D rigidbody;
    [SerializeField] float speed = 10f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }




    private void MoveBall()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector2.left * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector2.right * speed);
        }
    }
}
