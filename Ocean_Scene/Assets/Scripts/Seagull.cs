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

        followT.GetComponent<Seagull_Path>().seagullMain = gameObject;
    }

    public void Update()
    {
        Vector3 direction = followT.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, followT.transform.position, moveSpeedS * Time.deltaTime);
    }

    public void nextCamera()
    {
        GameObject newCam = Instantiate(camera, camera.transform.position, camera.transform.rotation);
        newCam.GetComponent<hasCamera>().whichCamera = 1;
        newCam.GetComponent<moveCam>().enabled = true;
        
        Destroy(gameObject.transform.GetChild(0).gameObject);
        
    }
}
