using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class WallHitCamSwap : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
  //  public GameObject followTarget;
    public GameObject lookAtTarget;

    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that was hit has a tag of "rag"
        if (collision.gameObject.CompareTag("wall"))
        {
            // Update the follow target
           // vcam.Follow = lookAtTarget.gameObject.transform;
           // followTarget = collision.gameObject;

            // Update the look-at target
            vcam.LookAt = lookAtTarget.gameObject.transform;
            lookAtTarget = lookAtTarget.gameObject;
        }
    }
}
