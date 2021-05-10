using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkMove : MonoBehaviour
{
    public GameObject kfish;
    public GameObject followFish;
    
    public float moveSpeed;
    public float lookSpeed;

    public bool first;
    
    public void OnEnable()
    {
        kfish = GameObject.FindGameObjectWithTag("KFish");
        followFish = kfish.transform.GetChild(1).GetChild(1).gameObject;
    }
    
    public void Update()
    {
        float dist = Vector3.Distance(followFish.transform.position, transform.position);

        if (!first)
        {
            Vector3 direction = followFish.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);
        }
        

        transform.position = Vector3.MoveTowards(transform.position, followFish.transform.position, moveSpeed * Time.deltaTime);

        if (dist <= 1 && !first)
        {
            first = true;
            parentSet();
        }
    }

    public void parentSet()
    {
        transform.parent = followFish.transform;
        transform.position = followFish.transform.position;
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    }
}
