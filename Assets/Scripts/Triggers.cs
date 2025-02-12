using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public GameObject Tourches;


    private void Start()
    {
        Tourches.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Tourches.SetActive(true);

        }

    }
}
