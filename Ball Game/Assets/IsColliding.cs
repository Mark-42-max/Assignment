using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsColliding : MonoBehaviour
{
    EdgeCollider2D edge;


    // Start is called before the first frame update
    void Start()
    {

        edge = GetComponent<EdgeCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            edge.enabled = false;
        }
    }
}
