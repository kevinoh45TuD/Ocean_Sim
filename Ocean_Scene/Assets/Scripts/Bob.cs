using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{

    public float heightChange;

    public float changeTime;
    public float currentTime;

    public bool goingUp;

    public Vector3 boatVector;
    
    void Update()
    {
        boatVector = new Vector3(0f, heightChange, 0f);
        currentTime += Time.deltaTime;
        
        if (goingUp == true)
        {
            gameObject.transform.position += boatVector;
        }
        else
        {
            gameObject.transform.position -= boatVector;
        }

        if (currentTime >= changeTime)
        {
            goingUp = !goingUp;
            currentTime = 0;
        }
    }
        
}
