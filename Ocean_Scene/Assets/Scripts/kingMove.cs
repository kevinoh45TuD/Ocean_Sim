using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kingMove : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject destination;
    public float moveSpeed;
    public float lookSpeed;
    
    public void OnEnable()
    {
        destination = GameObject.FindGameObjectWithTag("FinalDestination");
        endScreen = GameObject.FindGameObjectWithTag("end");
    }

    public void Update()
    {
        float dist = Vector3.Distance(destination.transform.position, transform.position);
        
        Vector3 direction = destination.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, moveSpeed * Time.deltaTime);

        if (dist <= 1)
        {
            endScene();
        }
    }

    public void endScene()
    {
        endScreen.transform.GetChild(0).gameObject.SetActive(true);
    }
}
