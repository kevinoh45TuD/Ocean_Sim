using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float distanceOrigin;
    public Transform originSpawn;

    public float moveTimer;
    public float forwardDistance;
    public float rotateDistance;
    public int moveAmount;

    public void OnEnable()
    {
        StartCoroutine(moveFish(moveTimer));
    }

    public void Update()
    {
        float dist = Vector3.Distance(transform.position, originSpawn.position);

        if (dist >= distanceOrigin)
        {
            Destroy(gameObject);
        }
    }

    public void callSwim()
    {
        StartCoroutine(moveFish(moveTimer));
    }

    public IEnumerator moveFish(float waitTime)
    {
        for (int i = 0; i < moveAmount; i++)
        {
            transform.position += transform.forward * forwardDistance;
            transform.Rotate(0, rotateDistance, 0);
            //callSwim();
            yield return new WaitForSeconds(waitTime);
        }
        
    }
}
