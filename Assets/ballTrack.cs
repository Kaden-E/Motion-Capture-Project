using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTrack : MonoBehaviour
{
    [SerializeField] private Transform ball;

    private void Update()
    {
        var transformPosition = transform.position;
        transformPosition.z = ball.transform.position.z;
    }
}
