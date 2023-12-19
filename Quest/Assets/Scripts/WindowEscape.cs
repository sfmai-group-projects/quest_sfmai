using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowEscape : MonoBehaviour
{
    public KeyCode key;
    public int sceneIndex;
    public bool ColliderHit = false;
    public bool All = false;
    public GameObject camera;


    public void Start()
    {
        camera = GameObject.FindWithTag("Camera");
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
            camera.SetActive(false);
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
