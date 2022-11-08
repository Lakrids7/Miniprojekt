using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBoulder : MonoBehaviour
{
    Vector3 startPosition;
    Rigidbody rigidbody;
    public float waitTime;
    void Start()
    {
        //Stores the starting position of the boulder and starts a courotine
        startPosition = this.gameObject.transform.position;
        StartCoroutine(platformResetTimer());
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    IEnumerator platformResetTimer()
    {
        //Waits for a certain amount of time (is set in the unity interface), and after the time has passed, the boulder is reset to its original position along with its velocity being reset
        yield return new WaitForSeconds(waitTime);
        this.gameObject.transform.position = startPosition;
        rigidbody.velocity = new Vector3(0, 0, 0);
        //The courotine resets itself in order to have the boulder keep falling and respawning
        StartCoroutine(platformResetTimer());
    }
}
