using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // this destroys the dog
        Destroy(gameObject);
        // destroys the ball when the dog hits it
        Destroy(other.gameObject);
    }
}


