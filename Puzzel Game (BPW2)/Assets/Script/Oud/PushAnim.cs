using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushAnim : MonoBehaviour


{

    public Animator pushAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pilaar 1" || other.tag == "Pilaar 2" || other.tag == "Pilaar 3" || other.tag == "Pilaar 4" || other.tag == "Pilaar 5")
        {
            pushAnim.SetTrigger("push");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Pilaar 1" || other.tag == "Pilaar 2" || other.tag == "Pilaar 3" || other.tag == "Pilaar 4" || other.tag == "Pilaar 5")
        {
            pushAnim.SetTrigger("stop push");
        }
    }
}
