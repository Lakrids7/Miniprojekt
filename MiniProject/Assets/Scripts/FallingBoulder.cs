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
        startPosition = this.gameObject.transform.position;
        StartCoroutine(platformResetTimer());
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    IEnumerator platformResetTimer()
    {
        yield return new WaitForSeconds(waitTime);
        this.gameObject.transform.position = startPosition;
        rigidbody.velocity = new Vector3(0, 0, 0);

        StartCoroutine(platformResetTimer());
    }
}
