using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    public KeyCode key;
    public Animator animator;
    public GameObject player;
    public GameObject door308;
    public AudioSource open;
    public bool ColliderHit = false;
    public bool all = false;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
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
        if (Input.GetKey(key) && ColliderHit == true)
        {
            return all = true;
        }
        else return all = false;
    }


    public void Update()
    {
        if (Inventory.Key308Taken == true)
        {
            Destroy(door308.GetComponent<DoorLocker>());
        }

        if (all == true && Inventory.Key308Taken == true)
        {
            open.Play();
            animator.enabled = true;
            Destroy(this);
        }
    }
}
