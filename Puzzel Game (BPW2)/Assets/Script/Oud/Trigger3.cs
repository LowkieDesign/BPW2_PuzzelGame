using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    [SerializeField] GameObject door;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Pilaar 3")) return;

        door.transform.position += new Vector3(5, 0, 0);
    }
}
