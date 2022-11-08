using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingPlatform : MonoBehaviour
{
    public GameObject platform;
    bool isSinking = false;
    Vector3 OriginalPosition;
    private void Start()
    {
        //Original position is stored 
        OriginalPosition = platform.transform.position;
    }
    private void Update()
    {
        //Sinks the platform by translating its position -3f in its y-axis
        if(isSinking == true)
        {
            platform.transform.Translate((new Vector3(0, -3f, 0)) * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //If the player steps on the platform, and the platform isnt already sinking, it starts sinking and starts a courotine
        if (isSinking == false && other.gameObject.CompareTag("Player"))
        {
            isSinking = true;
            StartCoroutine(SinkingTimer());
        }
        //The courotine is used to respawn the platform after 5 seconds have passed 
        IEnumerator SinkingTimer()
        {
            yield return new WaitForSeconds(5);
            platform.transform.position = OriginalPosition;
            isSinking = false;

        }
    }
}
