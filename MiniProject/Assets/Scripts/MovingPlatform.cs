using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject movingPlatform;
    private Vector3 originalPosition;
    public int x, y, z;
    private float movementTime;
    public float maxMovementTime;   
    private bool playerHasTouched = false;

    private void Start()
    {
        originalPosition = movingPlatform.transform.position;
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

            IEnumerator platformResetTimer()
            {
                this.transform.DetachChildren();
                yield return new WaitForSeconds(2f);
                movingPlatform.gameObject.transform.position = new Vector3(999f, 999f, 999f);
                yield return new WaitForSeconds(2f);
                movingPlatform.gameObject.transform.position = originalPosition;
            }
        }
        else movementTime = Time.unscaledTime;

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




}


