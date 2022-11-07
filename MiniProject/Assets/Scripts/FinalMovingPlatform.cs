using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalMovingPlatform : MonoBehaviour
{
    public GameObject movingPlatform;
    private Vector3 originalPosition;
    public int x, y, z;
    private float movementTime;
    public float maxMovementTime;   
    private bool playerHasTouched = false;
    public static bool playerDied = false;

    private void Start()
    {
        originalPosition = movingPlatform.transform.position;
        playerDied = false;
    }
    void Update()
    {
        

        if (playerHasTouched == true)
        {
            movingPlatform.gameObject.transform.Translate(x*Time.deltaTime, y*Time.deltaTime, z* Time.deltaTime);
            if (Time.unscaledTime > movementTime + maxMovementTime)
            {
                playerHasTouched = false;
                StartCoroutine(platformResetTimer());
            }
        }
        else movementTime = Time.unscaledTime;

        if (playerDied == true)
        {
            playerHasTouched = false;
            StartCoroutine(playerDiedReset());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(this.transform);
            playerHasTouched = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
    IEnumerator platformResetTimer()
    {
        this.transform.DetachChildren();
        yield return new WaitForSeconds(2f);
        movingPlatform.gameObject.transform.position = new Vector3(999f, 999f, 999f);
        yield return new WaitForSeconds(2f);
        movingPlatform.gameObject.transform.position = originalPosition;
    }

    IEnumerator playerDiedReset()
    {
        this.transform.DetachChildren();
        yield return new WaitForSeconds(1f);
        movingPlatform.gameObject.transform.position = originalPosition;
        playerDied = false;
    }




}


