using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Manager : MonoBehaviour
{
    public int cameraIndex;

    public Camera[] sceneCameras;

    public void nextCamera()
    {
        
        sceneCameras[cameraIndex].gameObject.SetActive(false);
        
        if (cameraIndex == sceneCameras.Length -1)
        {
            cameraIndex = 0;
        }
        else
        {
            cameraIndex += 1;
        }
        
        sceneCameras[cameraIndex].gameObject.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            nextCamera();
        }
    }
}
