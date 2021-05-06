﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public GameObject fishPrefab;
    public GameObject boatPrefab;
    public GameObject boatPrefab2;

    public int amountOfFish;
    public int amountOfBoat;

    public float rotateAmount;

    public float boatFLOAT;

    public void OnEnable()
    {
        boatFLOAT = 360 / amountOfBoat;
        
        for (int i = 0; i < amountOfFish; i++)
        {
            GameObject Go = Instantiate(fishPrefab, transform.position, transform.rotation);
            Go.transform.Rotate(0,i * rotateAmount, 0);
            Go.GetComponent<Fish>().originSpawn = gameObject.transform;
        }

        for (int i = 0; i < amountOfBoat; i++)
        {
            GameObject Go = Instantiate(boatPrefab, transform.position, transform.rotation);
            GameObject Go2 = Instantiate(boatPrefab2, transform.position, transform.rotation);
            Go.transform.Rotate(0,i * boatFLOAT, 0);
            Go2.transform.Rotate(0,i * boatFLOAT, 0);
            Go.GetComponent<boat>().originSpawn = gameObject.transform;
            Go2.GetComponent<boat>().originSpawn = gameObject.transform;
        }
    }
}
