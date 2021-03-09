using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    new Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        rigidbody.freezeRotation = true;    //so that on collision the camera doesn't rotate around

        rigidbody.velocity = transform.up * (-2);   //scroll the camera down frame by frame
    }
}
