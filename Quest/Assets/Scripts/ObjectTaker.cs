using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTaker : MonoBehaviour
{
    public KeyCode key;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject AudioObject;
    public AudioSource take;
    public bool ColliderHit;
    public bool All;
    private static GameObject instance;
    public int tag;


    public void Awake()
    {
        if (Inventory.Key308Taken == true && tag == 1)
        {
            Item1.SetActive(false);
        }

        if (Inventory.KeyStairsTaken == true && tag == 2)
        {
            Item2.SetActive(false);
        }
    }


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

            if (tag == 1)
            {
                Inventory.Key308Taken = true;
                Item1.SetActive(false);
            }

            if (tag == 2)
            {
                Inventory.KeyStairsTaken = true;
                Item2.SetActive(false);
            }

        }
    }
}
