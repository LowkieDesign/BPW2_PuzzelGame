using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    [SerializeField] GameObject door;


    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Pilaar 1")) return;
        door.transform.position += new Vector3(5, 0, 0);
    }
}
