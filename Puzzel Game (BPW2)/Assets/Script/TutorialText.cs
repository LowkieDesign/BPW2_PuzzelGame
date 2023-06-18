using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialText : MonoBehaviour
{
    public GameObject Tutorial;

    private bool triggered = false;


    // Use this for initialization
    void Start()
    {
        Tutorial.SetActive(false);

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && !triggered)
        {
            Tutorial.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        Tutorial.SetActive(false);
    }
}
