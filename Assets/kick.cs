using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class kick : MonoBehaviour
{
    public Rigidbody _rb;
    [SerializeField] private float jumpHeight;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetButtonDown("Jump")) 
            _rb.AddForce(transform.up * jumpHeight, ForceMode.Impulse);
            
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("deez"))
        {
            Debug.Log("deez is hitting fr");
            _rb.AddForce(-jumpHeight, -200, -200);            
        }
    }
    
}
