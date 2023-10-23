using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpener : MonoBehaviour
{
    public KeyCode key;
    public int sceneIndex;
    public int i = 0;

    public int OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return i = 1000;
        }
        else return i = 0;
    }

    public int OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return i = 1000;
        }
        else return i = 0;
    }

    public int OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            return i = 0;
        }
        else return i = 0;
    }

    public void OnMouseOver()
    {
        if (Input.GetKey(key) && i == 1000)
        {
            Debug.Log("Смена сцены...");
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
