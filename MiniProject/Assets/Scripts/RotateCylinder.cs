using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCylinder : MonoBehaviour
{

    void Update()
    {
        this.gameObject.transform.Rotate(0, 1, 0);
    }
}
