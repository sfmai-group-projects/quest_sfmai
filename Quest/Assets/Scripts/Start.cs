using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public bool ColliderHit;
    public bool All;
    public GameObject door305;
    public GameObject floor;
    public GameObject BlackDoor;
    public AudioSource doorslammed;
    public AudioSource black;

    public bool OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = true;
        }
        else return ColliderHit = false;
    }


    public bool OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = true;
        }
        else return ColliderHit = false;
    }


    public bool OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return ColliderHit = false;
        }
        else return ColliderHit = false;
    }


    public bool OnMouseEnter()
    {
        if (ColliderHit == true)
        {
            doorslammed.Play();
            black.Play();
            return All = true;
        }
        else return All = false;
    }


    IEnumerator TriggerDelay()
    {
        yield return new WaitForSeconds(3f);
        floor.SetActive(false);
        BlackDoor.SetActive(true);
    }


    public void Update()
    {
        if (All == true)
        {
            door305.SetActive(true);
            StartCoroutine(TriggerDelay());
        }
    }
}
