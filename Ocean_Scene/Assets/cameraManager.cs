using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    public GameObject[] cameraList;

    public int cameraIndex;


    public void nextCamera()
    {
        cameraList[cameraIndex].SetActive(false);
        cameraIndex++;
        cameraList[cameraIndex].SetActive(true);
        
    }
}
