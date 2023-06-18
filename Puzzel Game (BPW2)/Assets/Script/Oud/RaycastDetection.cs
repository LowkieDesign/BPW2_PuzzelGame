using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastDetection : MonoBehaviour
{
    public float range = 5;
    void Update()
    {
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range), Color.white);

    }
    }
