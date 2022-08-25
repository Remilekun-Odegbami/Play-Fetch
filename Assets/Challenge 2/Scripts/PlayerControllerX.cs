using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    bool readyToInstantiate;

    void Start()
    {
        readyToInstantiate = true;
    }

    void Update()
    {
        if (readyToInstantiate && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(PreventSpam());

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    IEnumerator PreventSpam()
    {
        // this stops the users from shooting multiple dogs at once 
        readyToInstantiate = false;
        // the wait time
        yield return new WaitForSeconds(1);
        // this enables the user shoot another dog after 1 second
        readyToInstantiate = true;
    }

}
