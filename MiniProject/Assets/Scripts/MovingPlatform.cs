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
        //The original position of the moving platform is stored 
        originalPosition = movingPlatform.transform.position;
    }
    void Update()
    {
        //If the player has touched the platform, the platform starts moving in either x,y or z direction for a certain amount of time (all of this is set in the unity interface)
        if (playerHasTouched == true)
        {
            movingPlatform.gameObject.transform.Translate(x*Time.deltaTime, y*Time.deltaTime, z* Time.deltaTime);
            //When the specified time has passed, a courotine runs which resets the position of the platform
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
        //When the player is on the platform, it is set as a child of the platform in order to have it move along with the platform 
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


