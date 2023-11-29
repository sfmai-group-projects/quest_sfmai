using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocker : MonoBehaviour
{
    public KeyCode key;
    public GameObject Message;
    public GameObject Text;
    public AudioSource open;
    public bool ColliderHit = false;

    public void Start()
    {
        Message = GameObject.FindGameObjectWithTag("Message");
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

    public void OnMouseOver()
    {
        if (Input.GetKeyDown(key) && ColliderHit == true)
        {
            open.Play();
        }
    }
}
