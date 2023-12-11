using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    public KeyCode key;
    private Animator animator;
    public GameObject player;
    public GameObject DoorKey;
    public AudioSource open;
    public Vector3 pos;
    public bool ColliderHit = false;
    public bool all = false;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
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


    [SerializeField]
    public void Update()
    {
        if (all == true && DoorKey.GetComponent<ObjectTaker>().All == true)
        {
            open.Play();
            player.transform.position = pos;
            all = false;
        }
    }
}