using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTaker : MonoBehaviour
{
    public KeyCode key;
    public GameObject Key308;
    public GameObject AudioObject;
    public AudioSource take;
    public bool ColliderHit;
    public bool All;

    public void Start()
    {
        AudioObject = GameObject.Find("KeyAudio");
        take = AudioObject.GetComponent<AudioSource>();
    }

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


    public bool OnMouseOver()
    {
        if (Input.GetKeyDown(key) && ColliderHit == true)
        {
            return All = true;
        }
        else return All = false;
    }


    public void Update()
    {
        if (All == true)
        {
            take.Play();
            Key308.SetActive(false);
        }
    }
}
