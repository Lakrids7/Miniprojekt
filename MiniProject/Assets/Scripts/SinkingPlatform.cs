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
        OriginalPosition = platform.transform.position;
    }
    private void Update()
    {
        if(isSinking == true)
        {
            platform.transform.Translate((new Vector3(0, -3f, 0)) * Time.deltaTime);
        }
        /*while (isSinking && platform.transform.position.y > -4)
        {
            Debug.Log("IS SINKING");
            platform.transform.position -= new Vector3(0.1f , 0, 0);
            if (platform.transform.position.y > 0)
            {
                platform.transform.position = OriginalPosition;
                isSinking = false;
            }
        }
        */

    }
    private void OnTriggerEnter(Collider other)
    {
        if (isSinking == false && other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TRIGGER ENTERED");
            isSinking = true;
            StartCoroutine(SinkingTimer());
        }

        IEnumerator SinkingTimer()
        {
            yield return new WaitForSeconds(5);
            platform.transform.position = OriginalPosition;
            isSinking = false;
            Debug.Log("STOPS SINKING");

        }
    }
}
