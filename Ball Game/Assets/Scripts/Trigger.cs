using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Trigger : MonoBehaviour
{
    public GameObject[] platPrefabs;    //all the backgrounds together stored in an array of elements

    private Transform tracer;   //traces wheather camera triggers respawn or not

    private float spawnY = -5.0f;    //only spawn on Y axis

    private float backLen = 65.0f;  //length of background;

    private int amtOfBacks = 2;     //number of background screens

    private List<GameObject> activeBack;    //keeps record of active background for caching validation

    private int lastPrefabInd = 0;

    private float safeZone = 68.0f;

    int prefabIndex = -1;


    private void Start()
    {
        activeBack = new List<GameObject>();
        tracer = GameObject.FindGameObjectWithTag("Respawn").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            SpawnBack();
            DeleteBack();
        }
    }


    private void SpawnBack()
    {
        GameObject go;
        go = Instantiate(platPrefabs[RandomPrefabIndex()]);
        go.transform.SetParent (transform);
        spawnY += backLen;
        go.transform.position = Vector2.down * spawnY;
        activeBack.Add(go);
    }

    private int RandomPrefabIndex()
    {
        if (platPrefabs.Length <= 1)
        {
            return 0;
        }

        int randomID = lastPrefabInd;
        while (randomID == lastPrefabInd)
        {
            randomID = Random.Range(0, platPrefabs.Length);
        }
        lastPrefabInd = randomID;
        return randomID;
    }
    private void DeleteBack()
    {
        print("TODO");
    }

}
