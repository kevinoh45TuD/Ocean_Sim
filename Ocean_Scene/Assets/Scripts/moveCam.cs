using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    
    public float xRot, yRot, zRot;

    public float timeLength;
    public float tempTime;

    public Vector3 camDest;

    public GameObject kingFish;
    public bool first;
    public Vector3 fishVector;

    public GameObject sharkMan;
    public Vector3 sharkPos;
    

    public void OnEnable()
    {
        tempTime = 0;

        kingFish = GameObject.FindGameObjectWithTag("KFish");
        
        
    }

    public void FixedUpdate()
    {
        tempTime += Time.deltaTime;

        Quaternion rotation = Quaternion.Euler(xRot, yRot, zRot);
        
        if (tempTime <= timeLength)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, (tempTime * Time.deltaTime)/timeLength);

            if (!first)
            {
                transform.position = Vector3.MoveTowards(transform.position, camDest, tempTime * Time.deltaTime);
            }

            if (first)
            {
                transform.position = Vector3.MoveTowards(transform.position, kingFish.transform.position + fishVector, tempTime * Time.deltaTime);
            }
        }

        if (tempTime >= 17 && !first)
        {
            newDestination();
            Instantiate(sharkMan, sharkPos, transform.rotation);
        }

        if (tempTime >= 9 && first)
        {
            kingFish.transform.GetChild(1).gameObject.SetActive(true);
            Destroy(gameObject);
            kingFish.GetComponent<fishFlock>().enabled = false;
            kingFish.GetComponent<kingMove>().enabled = true;
        }
        
    }

    public void newDestination()
    {
        first = true;
        
        xRot = 0;
        yRot = 180;
        zRot = 0;
        
        tempTime = 0;
    }
}
