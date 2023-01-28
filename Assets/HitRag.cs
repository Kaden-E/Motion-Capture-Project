using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRag : MonoBehaviour
{
     public Ragdoll rag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("rag"))
        {
            Debug.Log("hit rag");
            rag.ActivateRagdoll();
        }
    }
}
