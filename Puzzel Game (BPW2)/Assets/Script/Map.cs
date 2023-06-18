using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject TreMap;




    // Use this for initialization
    void Start()
    {
        TreMap.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            TreMap.SetActive(true);
        }

        if (TreMap.activeInHierarchy == true && Input.GetKey(KeyCode.Escape))
        {
            TreMap.SetActive(false); ;
        }

    }

}
