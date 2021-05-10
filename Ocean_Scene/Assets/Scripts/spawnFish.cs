using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnFish : MonoBehaviour
{
    [Header("Initial")]
    
    public fishFlock fishPref;
    public int fishCount;
    public Vector3 spawnBounds;
    
    
    [Header("Speed")]
    
    [Range(0, 10)]
    public float _minSpeed;
    public float minSpeed { get { return _minSpeed; } }
    [Range(0, 10)]
    public float _maxSpeed;
    public float maxSpeed { get { return _maxSpeed; } }
    
    
    [Header("Distances")]
    
    [Range(0, 10)]
    public float _cohesionDistance;
    public float cohesionDistance { get { return _cohesionDistance; } }

    [Range(0, 10)]
    public float _avoidanceDistance;
    public float avoidanceDistance { get { return _avoidanceDistance; } }

    [Range(0, 10)]
    public float _aligementDistance;
    public float aligementDistance { get { return _aligementDistance; } }

    [Range(0, 100)]
    public float _boundsDistance;
    public float boundsDistance { get { return _boundsDistance; } }
    
    
    [Header("Weights")]
    
    [Range(0, 10)]
    public float _cohesionWeight;
    public float cohesionWeight { get { return _cohesionWeight; } }

    [Range(0, 10)]
    public float _avoidanceWeight;
    public float avoidanceWeight { get { return _avoidanceWeight; } }

    [Range(0, 10)]
    public float _aligementWeight;
    public float aligementWeight { get { return _aligementWeight; } }

    [Range(0, 10)]
    public float _boundsWeight;
    public float boundsWeight { get { return _boundsWeight; } }
    
    public fishFlock[] activeFish { get; set; }

    public int whoKing;
    public GameObject kingFish;

    public void OnEnable()
    {
        fishInstant();
    }

    public void fishInstant()
    {
        activeFish = new fishFlock[fishCount];

        for (int i = 0; i < fishCount; i++)
        {
            Vector3 randomVector3 = UnityEngine.Random.insideUnitSphere;
            randomVector3 = new Vector3(randomVector3.x * spawnBounds.x, randomVector3.y * spawnBounds.y,randomVector3.z * spawnBounds.z);

            Vector3 spawnPos = transform.position + randomVector3;
            Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            activeFish[i] = Instantiate(fishPref, spawnPos, rotation);
            
            activeFish[i].AssignFlock(this);
            activeFish[i].StartSpeed(UnityEngine.Random.Range(minSpeed, maxSpeed));
        }
        
        setKing();
    }

    public void Update()
    {
        for (int i = 0; i < activeFish.Length; i++)
        {
            activeFish[i].MoveFish();
        }
    }

    public void setKing()
    {
        whoKing = Random.Range(0, fishCount);
        kingFish = activeFish[whoKing].gameObject;
        kingFish.transform.GetChild(0).GetComponent<TrailRenderer>().enabled = false;
        kingFish.GetComponent<TrailRenderer>().enabled = true;
        kingFish.transform.tag = "KFish";
    }
}
