﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Seagull_Manager : MonoBehaviour
{
        public GameObject seagullPrefab;

        public Transform[] seagullSpawnSpots;
        public GameObject[] activeSeagulls;

        public GameObject seagullFollow;
        
        [Range(1.0f, 20.0f)]
        public float xMin, xMax;
        [Range(1.0f, 20.0f)]
        public float zMin, zMax;

        public Vector3 seagullSpawn;

        public void OnEnable()
        {
                for (int i = 0; i < activeSeagulls.Length; i++)
                {
                      seagullSpawn = seagullSpawnSpots[i].position;
                      GameObject go = Instantiate(seagullPrefab, seagullSpawn, transform.rotation);
                      activeSeagulls[i] = go;
                }
                
                activeSeagulls[0].GetComponent<Seagull>().camera.SetActive(true);
        }
}
