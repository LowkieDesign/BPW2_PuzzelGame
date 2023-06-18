using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{

    public Animator fenceAnim;

    private void OnTriggerEnter(Collider other)
    {
     if (other.CompareTag("FenceTrigger"))
        {
            fenceAnim.SetTrigger("open");
        } 
    }

}
