using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject pilaar;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Pilaar 2")) return;

        door.transform.position += new Vector3(0, 4, 0);
        pilaar.transform.position += new Vector3(0, -1, 0);
    }
}
