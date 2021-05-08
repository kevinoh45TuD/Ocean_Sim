using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasCamera : MonoBehaviour
{
    public GameObject cameraManager;

    public int whichCamera;

    public void OnEnable()
    {
        cameraManager = GameObject.FindGameObjectWithTag("CManage");

        cameraManager.GetComponent<cameraManager>().cameraList[whichCamera] = gameObject;
    }
}
