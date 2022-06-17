using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnItsOwnAxis : MonoBehaviour
{
    public float rotationSpeed = 10f;


    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime);
    }
}
