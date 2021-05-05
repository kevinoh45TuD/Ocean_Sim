using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagull : MonoBehaviour
{
    public GameObject camera;

    public GameObject followT;
    public float lookSpeed;
    public float moveSpeedS;

    public void OnEnable()
    {
        followT = GameObject.FindGameObjectWithTag("FollowS");
    }

    public void Update()
    {
        Vector3 direction = followT.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, followT.transform.position, moveSpeedS * Time.deltaTime);
    }
}
