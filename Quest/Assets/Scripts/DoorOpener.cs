using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpener : MonoBehaviour
{
    public KeyCode key;
    public int sceneIndex;
    public AudioSource open;
    public bool ColliderHit = false;
    public bool All = false;

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

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(sceneIndex);
    }

    public void Update()
    {
        if (All == true)
        {
            open.Play();
            Debug.Log("Смена сцены...");
            LoadNextScene();
        }
    }
}
