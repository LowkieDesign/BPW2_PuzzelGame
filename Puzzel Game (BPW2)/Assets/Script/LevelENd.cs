using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelENd : MonoBehaviour
{
    public GameObject YouWin;
    public GameObject PressE;



    // Use this for initialization
    void Start()
    {
        YouWin.SetActive(false);
        PressE.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            YouWin.SetActive(true);
            PressE.SetActive(true);



            if (YouWin.activeInHierarchy == true && Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
