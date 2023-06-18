using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WrongChoice : MonoBehaviour
{
    public GameObject YourDead;
    public GameObject PressE;
    public GameObject Spikes;


    // Use this for initialization
    void Start()
    {
        YourDead.SetActive(false);
        PressE.SetActive(false);
        Spikes.SetActive(false);

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            YourDead.SetActive(true);
            PressE.SetActive(true);
            Spikes.SetActive(true);


            if (YourDead.activeInHierarchy == true && Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
            }
        }
    }
}
