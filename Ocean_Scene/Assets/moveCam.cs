using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public float yVal;
    public float xRot;

    public float timeLength;
    public float tempTime;

    public Vector3 camDest;

    public void OnEnable()
    {
        tempTime = 0;

    }

    public void FixedUpdate()
    {
        tempTime += Time.deltaTime;

        Quaternion rotation = Quaternion.Euler(xRot, 0, 0);
        
        if (tempTime <= timeLength)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, (tempTime * Time.deltaTime)/timeLength);
            
            transform.position = Vector3.MoveTowards(transform.position, camDest, tempTime * Time.deltaTime);
        }
        
    }
}
