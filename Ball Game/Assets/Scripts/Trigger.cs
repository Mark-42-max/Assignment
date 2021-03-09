using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject[] platPrefabs;    //all the backgrounds together stored in an array of elements

    private Transform tracer;   //traces wheather camera triggers respawn or not

    private float spawnY = 0.0f;    //only spawn on Y axis

    private float backLen = 64.0f;  //length of background;

    private int amtOfBacks = 2;     //number of background screens

    int prefabIndex = -1;


    private void Start()
    {
        tracer = GameObject.FindGameObjectWithTag("Respawn").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            SpawnBack();
        }
    }

    private void SpawnBack()
    {
        GameObject go;
        go = Instantiate(platPrefabs[0]);
        go.transform.SetParent (transform);
        spawnY += backLen;
        go.transform.position = Vector2.down * spawnY;
        
    }
}
