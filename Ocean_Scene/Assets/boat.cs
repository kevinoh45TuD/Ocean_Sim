using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    public float distanceOrigin;
    public Transform originSpawn;

    public float moveTimer;
    public float forwardDistance;
    public float rotateDistance;
    public int moveAmount;

    public bool spot;
    public bool checkRight;
    public float rotateTime;
    public float rotateSpeed;
    public float newDist;
    
    public void OnEnable()
    {
        StartCoroutine(moveBoat(moveTimer));
    }

    public void Update()
    {
        float dist = Vector3.Distance(transform.position, originSpawn.position);

        if (dist >= distanceOrigin)
        {
            Destroy(gameObject);
        }

        
        
        if(spot)
        {
            if (checkRight)
            {
                transform.RotateAround(originSpawn.transform.position, Vector3.up, rotateSpeed);
            }
            else
            {
                transform.RotateAround(originSpawn.transform.position, Vector3.down, rotateSpeed);
            }
            
        }
        
    }

    public void callSwim()
    {
        StartCoroutine(moveBoat(moveTimer));
    }

    public IEnumerator moveBoat(float waitTime)
    {
        for (int i = 0; i < moveAmount; i++)
        {
            transform.position += transform.forward * forwardDistance;
            transform.Rotate(0, rotateDistance, 0);
            //callSwim();
            yield return new WaitForSeconds(waitTime);
        }

        newDist = Vector3.Distance(transform.position, originSpawn.position);
        spot = true;

    }
}
