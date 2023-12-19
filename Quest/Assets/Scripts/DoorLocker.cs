using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorLocker : MonoBehaviour
{
    public KeyCode key;
    public GameObject Message;
    public TMP_Text text;
    public AudioSource open;
    public bool ColliderHit = false;
    public static bool All = false;


    public void Start()
    {
        Message = GameObject.FindGameObjectWithTag("Message");
        text = Message.GetComponent<TMP_Text>();
        text.faceColor = new Color32(255, 255, 255, 0);
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
            All = true;
        }
    }


    public void OnMouseExit()
    {
        All = false;
    }


    public void Update()
    {
        if (All == true)
        {
            text.faceColor = new Color32(255, 255, 255, 255);
        }
        else
        {
            text.faceColor = new Color32(255, 255, 255, 0);
        }
    }
}
