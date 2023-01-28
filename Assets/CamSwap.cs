using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;


public class CamSwap : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    public GameObject followTarget;
    public GameObject lookAtTarget;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that was hit has a tag of "rag"
        if (collision.gameObject.CompareTag("rag"))
        {
            // Update the follow target
            vcam.Follow = collision.gameObject.transform;
            followTarget = collision.gameObject;

            // Update the look-at target
            vcam.LookAt = collision.gameObject.transform;
            lookAtTarget = collision.gameObject;
        }
    }
    
    
}
