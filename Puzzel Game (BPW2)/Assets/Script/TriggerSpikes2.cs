using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpikes2 : MonoBehaviour
{

    [SerializeField] GameObject spikes;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Pilaar 1")) return;
        spikes.transform.position += new Vector3(0, 1, 0);
    }
}
