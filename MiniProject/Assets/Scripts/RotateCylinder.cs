using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0, 1, 0);
    }
}
