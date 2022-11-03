using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingObstacle : MonoBehaviour
{
    public GameObject swingBall;
    Rigidbody rigidbody;



    private void Start()
    {
        rigidbody = swingBall.transform.GetComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.right * 10, ForceMode.Acceleration);
    }
    void Update()
    {
        //StartCoroutine(AddForce());
        if(swingBall.transform.position.x >= 10)
        {
            rigidbody.AddForce(Vector3.left * 5, ForceMode.Acceleration);
        }
        if (swingBall.transform.position.x <= -10)
        {
            rigidbody.AddForce(Vector3.right * 5, ForceMode.Acceleration);
        }
    }

    /*IEnumerator AddForce()
    {
        rigidbody.AddForce(Vector3.right * 1, ForceMode.Force);
        yield return new WaitForSeconds(1);
    }
    */
}
