using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrikolistLaugh : MonoBehaviour
{
    public AudioSource laugh;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            laugh.Play();
        }
    }
}
