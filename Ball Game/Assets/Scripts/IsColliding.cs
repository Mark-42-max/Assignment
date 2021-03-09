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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("Dead");
        }
    }
}
