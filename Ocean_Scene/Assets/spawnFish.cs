using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnFish : MonoBehaviour
{
    public GameObject fishPref;
    public int fishCount;
    public Vector3 spawnBounds;

    public GameObject[] activeFish;

    public void OnEnable()
    {
        fishInstant();
    }

    public void fishInstant()
    {
        activeFish = new GameObject[fishCount];

        for (int i = 0; i < fishCount; i++)
        {
            Vector3 randomVector3 = UnityEngine.Random.insideUnitSphere;
            randomVector3 = new Vector3(randomVector3.x * spawnBounds.x, randomVector3.y * spawnBounds.y,randomVector3.z * spawnBounds.z);

            Vector3 spawnPos = transform.position + randomVector3;
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            activeFish[i] = Instantiate(fishPref, spawnPos, rotation);
        }
    }
}
