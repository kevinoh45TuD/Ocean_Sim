using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seagull_Path : MonoBehaviour
{
    public Transform[] pathSpots;

    public float moveSpeed;
    public float arriveDist;

    public int spotIndex;

    public void Update()
    {
        float dist = Vector3.Distance(pathSpots[spotIndex].position, transform.position);

        transform.position = Vector3.Lerp(transform.position, pathSpots[spotIndex].position, moveSpeed * Time.deltaTime);

        if (dist <= arriveDist)
        {
            spotIndex++;
        }

        if (spotIndex >= pathSpots.Length)
        {
            spotIndex = 0;
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        for (int i = 0; i < pathSpots.Length; i++)
        {
            Gizmos.DrawSphere(pathSpots[i].position, 1);

            if (i <= pathSpots.Length - 1)
            {
                Gizmos.DrawLine(pathSpots[i].position, pathSpots[i+1].position);
            }
            
        }
        
    }
}
