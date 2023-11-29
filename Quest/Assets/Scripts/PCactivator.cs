using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCactivator : MonoBehaviour
{
    public KeyCode key;
    public GameObject PCCamera;
    public GameObject PlayerCamera;
    public bool ColliderHit;
    public bool All;

    public void Start()
    {
        PlayerCamera = GameObject.FindGameObjectWithTag("Camera");
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
            PlayerCamera.SetActive(false);
            PCCamera.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerCamera.SetActive(true);
            PCCamera.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
