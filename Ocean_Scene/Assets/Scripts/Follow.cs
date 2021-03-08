using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    
    public GameObject targetObj;

    public Vector3 coords;
    
    void Update()
    {
        
        
        coords = new Vector3(targetObj.transform.position.x, targetObj.transform.position.y + 50, targetObj.transform.position.z);
        gameObject.transform.position = coords;
        transform.LookAt(targetObj.transform);
    }
    
}
